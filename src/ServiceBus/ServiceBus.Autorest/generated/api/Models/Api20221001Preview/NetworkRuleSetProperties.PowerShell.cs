// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.PowerShell;

    /// <summary>NetworkRuleSet properties</summary>
    [System.ComponentModel.TypeConverter(typeof(NetworkRuleSetPropertiesTypeConverter))]
    public partial class NetworkRuleSetProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.NetworkRuleSetProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.INetworkRuleSetProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.INetworkRuleSetProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new NetworkRuleSetProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.NetworkRuleSetProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.INetworkRuleSetProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.INetworkRuleSetProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new NetworkRuleSetProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="NetworkRuleSetProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="NetworkRuleSetProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.INetworkRuleSetProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.NetworkRuleSetProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal NetworkRuleSetProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("TrustedServiceAccessEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.INetworkRuleSetPropertiesInternal)this).TrustedServiceAccessEnabled = (bool?) content.GetValueForProperty("TrustedServiceAccessEnabled",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.INetworkRuleSetPropertiesInternal)this).TrustedServiceAccessEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("DefaultAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.INetworkRuleSetPropertiesInternal)this).DefaultAction = (Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Support.DefaultAction?) content.GetValueForProperty("DefaultAction",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.INetworkRuleSetPropertiesInternal)this).DefaultAction, Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Support.DefaultAction.CreateFrom);
            }
            if (content.Contains("VirtualNetworkRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.INetworkRuleSetPropertiesInternal)this).VirtualNetworkRule = (Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.INwRuleSetVirtualNetworkRules[]) content.GetValueForProperty("VirtualNetworkRule",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.INetworkRuleSetPropertiesInternal)this).VirtualNetworkRule, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.INwRuleSetVirtualNetworkRules>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.NwRuleSetVirtualNetworkRulesTypeConverter.ConvertFrom));
            }
            if (content.Contains("IPRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.INetworkRuleSetPropertiesInternal)this).IPRule = (Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.INwRuleSetIPRules[]) content.GetValueForProperty("IPRule",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.INetworkRuleSetPropertiesInternal)this).IPRule, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.INwRuleSetIPRules>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.NwRuleSetIPRulesTypeConverter.ConvertFrom));
            }
            if (content.Contains("PublicNetworkAccess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.INetworkRuleSetPropertiesInternal)this).PublicNetworkAccess = (Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Support.PublicNetworkAccessFlag?) content.GetValueForProperty("PublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.INetworkRuleSetPropertiesInternal)this).PublicNetworkAccess, Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Support.PublicNetworkAccessFlag.CreateFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.NetworkRuleSetProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal NetworkRuleSetProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("TrustedServiceAccessEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.INetworkRuleSetPropertiesInternal)this).TrustedServiceAccessEnabled = (bool?) content.GetValueForProperty("TrustedServiceAccessEnabled",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.INetworkRuleSetPropertiesInternal)this).TrustedServiceAccessEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("DefaultAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.INetworkRuleSetPropertiesInternal)this).DefaultAction = (Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Support.DefaultAction?) content.GetValueForProperty("DefaultAction",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.INetworkRuleSetPropertiesInternal)this).DefaultAction, Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Support.DefaultAction.CreateFrom);
            }
            if (content.Contains("VirtualNetworkRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.INetworkRuleSetPropertiesInternal)this).VirtualNetworkRule = (Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.INwRuleSetVirtualNetworkRules[]) content.GetValueForProperty("VirtualNetworkRule",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.INetworkRuleSetPropertiesInternal)this).VirtualNetworkRule, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.INwRuleSetVirtualNetworkRules>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.NwRuleSetVirtualNetworkRulesTypeConverter.ConvertFrom));
            }
            if (content.Contains("IPRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.INetworkRuleSetPropertiesInternal)this).IPRule = (Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.INwRuleSetIPRules[]) content.GetValueForProperty("IPRule",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.INetworkRuleSetPropertiesInternal)this).IPRule, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.INwRuleSetIPRules>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.NwRuleSetIPRulesTypeConverter.ConvertFrom));
            }
            if (content.Contains("PublicNetworkAccess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.INetworkRuleSetPropertiesInternal)this).PublicNetworkAccess = (Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Support.PublicNetworkAccessFlag?) content.GetValueForProperty("PublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.INetworkRuleSetPropertiesInternal)this).PublicNetworkAccess, Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Support.PublicNetworkAccessFlag.CreateFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// NetworkRuleSet properties
    [System.ComponentModel.TypeConverter(typeof(NetworkRuleSetPropertiesTypeConverter))]
    public partial interface INetworkRuleSetProperties

    {

    }
}