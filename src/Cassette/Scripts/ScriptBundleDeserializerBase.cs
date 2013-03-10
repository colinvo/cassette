using System.Xml.Linq;
using Cassette.TinyIoC;
using Cassette.Utilities;

namespace Cassette.Scripts
{
    abstract class ScriptBundleDeserializerBase<T> : BundleDeserializer<T>
        where T : ScriptBundle
    {
        protected ScriptBundleDeserializerBase(IUrlModifier urlModifier, TinyIoCContainer container)
            : base(urlModifier, container)
        {
        }

        protected void AssignScriptBundleProperties(T bundle, XElement element)
        {
            bundle.Condition = element.AttributeValueOrNull("Condition");
            bundle.Renderer = CreateHtmlRenderer<ScriptBundle>();
        }
    }
}