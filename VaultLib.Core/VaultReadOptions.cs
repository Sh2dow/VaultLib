namespace VaultLib.Core;

public sealed class VaultReadOptions
{
    public static VaultReadOptions Current { get; } = new VaultReadOptions();

    public bool AllowLayoutOverread { get; set; }
}
