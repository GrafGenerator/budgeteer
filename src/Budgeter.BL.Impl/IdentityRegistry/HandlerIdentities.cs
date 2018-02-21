using Budgeter.BL.Core.HandlingIdentities;

namespace Budgeter.BL.Impl.IdentityRegistry
{
    public static class HandlerIdentities
    {
        // 1000 - 1999 = ResourceEntryCategory
        public static HandlerIdentity AddResourceEntryCategory = Handler.Identity(1000, "Add resource entry category.");
    }
}