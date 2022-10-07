using Terrasoft.Common;
using Terrasoft.Core;

namespace Terrasoft.Configuration
{
    public class LrnLocalizableStringHelper
    {
        public static LocalizableString Get<T>(UserConnection userConnection, string key)
        {
            var localizableString = $"LocalizableStrings.{key}.Value";
            return new LocalizableString(userConnection.ResourceStorage, typeof(T).Name, localizableString);
        }
    }
}