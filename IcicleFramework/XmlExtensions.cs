using System.Xml;

namespace IcicleFramework
{
    /// <summary>
    /// Contains extension methods for the System.Xml namespace.
    /// </summary>
    public static class XmlExtensions
    {
        /// <summary>
        /// Gets the first <see cref="XmlNode"/> in an <see cref="XmlNodeList"/>,
        /// or null if the list is empty/null.
        /// </summary>
        public static XmlNode FirstOrDefault(this XmlNodeList nodeList)
        {
            if (nodeList == null || nodeList.Count == 0)
            {
                return default(XmlNode);
            }

            return nodeList[0];
        }
    }
}
