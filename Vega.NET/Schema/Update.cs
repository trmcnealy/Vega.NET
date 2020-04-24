namespace Vega.Schema
{
    public struct Update
    {
        public string     String;
        public UpdateType UpdateType;

        public static implicit operator Update(string     String)     => new Update { String     = String };
        public static implicit operator Update(UpdateType updateType) => new Update { UpdateType = updateType };
    }
}