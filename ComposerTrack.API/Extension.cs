#nullable disable
namespace ComposerTrack.API
{
    public abstract class Extension
    {
        public string Name { get; private set; }
        public string ID { get; private set; }
        public string Description { get; set; }
        public string Author { get; set; }

        public Extension(string name, string id)
        {
        }
    }
}