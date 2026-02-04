using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using VaultLib.Core.Data;
using VaultLib.Core.DataInterfaces;
using VaultLib.Core.Exports;

namespace VaultLib.Core.Writer;

/// <summary>
/// Manages information about exports to be built into a file.
/// </summary>
public class VaultExportManager<TKey> where TKey : struct, IKey<TKey>
{
    private VaultWriteContext<TKey> WriteContext { get; }
    private List<BaseExport<TKey>> Exports { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="VaultExportManager{TKey}"/> class.
    /// </summary>
    /// <param name="writeContext">The vault to build exports for.</param>
    public VaultExportManager(VaultWriteContext<TKey> writeContext)
    {
        WriteContext = writeContext;
        Exports = new List<BaseExport<TKey>>();
    }

    /// <summary>
    /// Builds exports for the vault.
    /// </summary>
    /// <remarks>This resets the list of exports.</remarks>
    public void BuildVaultExports()
    {
        Exports.Clear();

        var exportFactory = WriteContext.Database.ExportFactory;
        var collectionDepthCache = new Dictionary<VltCollection<TKey>, int>();

        int GetCollectionDepth(VltCollection<TKey> collection)
        {
            if (collectionDepthCache.TryGetValue(collection, out var depth))
            {
                return depth;
            }

            depth = 0;
            var current = collection.Parent;
            while (current != null)
            {
                depth++;
                current = current.Parent;
            }

            collectionDepthCache[collection] = depth;
            return depth;
        }

        if (WriteContext.Vault.IsPrimaryVault)
        {
            Exports.Add(exportFactory.BuildDatabaseLoad());

            foreach (var vltClass in WriteContext.Database.Classes.OrderBy(c => c.Key))
            {
                Exports.Add(exportFactory.BuildClassLoad(vltClass));
                var orderedCollections = WriteContext.Collections
                    .Select((collection, index) => new { collection, index })
                    .Where(item => item.collection.Class.Key == vltClass.Key)
                    .OrderBy(item => GetCollectionDepth(item.collection))
                    .ThenBy(item => item.collection.Key)
                    .ThenBy(item => item.index)
                    .Select(item => item.collection);

                Exports.AddRange(from collection in orderedCollections
                    select exportFactory.BuildCollectionLoad(collection));
            }
        }
        else
        {
            var orderedCollections = WriteContext.Collections
                .Select((collection, index) => new { collection, index })
                .OrderBy(item => item.collection.Class.Key)
                .ThenBy(item => GetCollectionDepth(item.collection))
                .ThenBy(item => item.collection.Key)
                .ThenBy(item => item.index)
                .Select(item => item.collection);

            Exports.AddRange(from collection in orderedCollections
                select exportFactory.BuildCollectionLoad(collection));
        }
    }

    /// <summary>
    /// Performs preparation work on each export.
    /// </summary>
    public void PrepareExports()
    {
        Exports.ForEach(e => e.Prepare(WriteContext.Vault));
    }

    /// <summary>
    /// Adds an export to the list of exports.
    /// </summary>
    /// <param name="export">The export to add.</param>
    public void AddExport(BaseExport<TKey> export)
    {
        Exports.Add(export);
    }

    /// <summary>
    /// Gets a read-only view of the list of exports.
    /// </summary>
    /// <returns>The read-only list of exports.</returns>
    public IList<BaseExport<TKey>> GetExports()
    {
        return new ReadOnlyCollection<BaseExport<TKey>>(Exports);
    }
}
