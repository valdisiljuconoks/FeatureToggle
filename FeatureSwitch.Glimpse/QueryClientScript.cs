using Glimpse.Core.Extensibility;

namespace FeatureSwitch.Glimpse
{
    public class QueryClientScript : IStaticClientScript
    {
        public ScriptOrder Order
        {
            get
            {
                return ScriptOrder.IncludeAfterClientInterfaceScript;
            }
        }

        public string GetUri(string version)
        {
            return "/FeatureSwitchConfigScript";
        }
    }
}
