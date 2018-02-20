namespace Budgeter.BL.Core.HandlingIdentities
{
    public class HandlerIdentity
    {
        public HandlerIdentity(int id, string description)
        {
            Id = id;
            Description = description;
        }

        public int Id { get; }
        public string Description { get; }
    }
}