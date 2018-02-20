namespace Budgeter.BL.Core.HandlingIdentities
{
    public static class Handler
    {
        public static HandlerIdentity Identity(int id, string description = "{ no andler desctiption provided }") =>
            new HandlerIdentity(id, description);
    }
}