﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.VisualStudio.ServiceReference.Platforms, version 14.0.23107.0
// 
namespace Syncfusion.SampleBrowser.UWP.PivotClient.OlapManagerService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="", ConfigurationName="OlapManagerService.IOlapDataProvider")]
    public interface IOlapDataProvider {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IOlapDataProvider/GetJSONData", ReplyAction="urn:IOlapDataProvider/GetJSONDataResponse")]
        System.Threading.Tasks.Task<string> GetJSONDataAsync(string mDXQuery, string currentReport, bool allowMdxToOlapReportParse);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IOlapDataProvider/GetJSONCubeSchema", ReplyAction="urn:IOlapDataProvider/GetJSONCubeSchemaResponse")]
        System.Threading.Tasks.Task<string> GetJSONCubeSchemaAsync(string cubeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IOlapDataProvider/GetJSONMeasureGroupsDimensions", ReplyAction="urn:IOlapDataProvider/GetJSONMeasureGroupsDimensionsResponse")]
        System.Threading.Tasks.Task<string> GetJSONMeasureGroupsDimensionsAsync(string cubeName, string measureGroupName);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IOlapDataProvider/GetJSONParentMember", ReplyAction="urn:IOlapDataProvider/GetJSONParentMemberResponse")]
        System.Threading.Tasks.Task<string> GetJSONParentMemberAsync(string uniqueName, string currentCubeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IOlapDataProvider/GetJSONCubes", ReplyAction="urn:IOlapDataProvider/GetJSONCubesResponse")]
        System.Threading.Tasks.Task<string> GetJSONCubesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IOlapDataProvider/GetJSONChildMembers", ReplyAction="urn:IOlapDataProvider/GetJSONChildMembersResponse")]
        System.Threading.Tasks.Task<string> GetJSONChildMembersAsync(string cubeName, string levelName);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IOlapDataProvider/GetJSONChildrenByMDX", ReplyAction="urn:IOlapDataProvider/GetJSONChildrenByMDXResponse")]
        System.Threading.Tasks.Task<string> GetJSONChildrenByMDXAsync(string command);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IOlapDataProvider/GetJSONDataWithTotalCount", ReplyAction="urn:IOlapDataProvider/GetJSONDataWithTotalCountResponse")]
        System.Threading.Tasks.Task<string> GetJSONDataWithTotalCountAsync(string currentReport);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IOlapDataProvider/GetJSONLevelMembersUsingMdx", ReplyAction="urn:IOlapDataProvider/GetJSONLevelMembersUsingMdxResponse")]
        System.Threading.Tasks.Task<string> GetJSONLevelMembersUsingMdxAsync(string memberUniqueName, int axisPosition, bool isGrandTotalOn, string cubeName, string pagingParams);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IOlapDataProvider/GetJSONExecuteMemberCount", ReplyAction="urn:IOlapDataProvider/GetJSONExecuteMemberCountResponse")]
        System.Threading.Tasks.Task<string> GetJSONExecuteMemberCountAsync(string mdxQuery);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:IOlapDataProvider/GetJSONExecuteDrillThroughQuery", ReplyAction="urn:IOlapDataProvider/GetJSONExecuteDrillThroughQueryResponse")]
        System.Threading.Tasks.Task<string> GetJSONExecuteDrillThroughQueryAsync(string mdxQuery);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOlapDataProviderChannel : Syncfusion.SampleBrowser.UWP.PivotClient.OlapManagerService.IOlapDataProvider, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OlapDataProviderClient : System.ServiceModel.ClientBase<Syncfusion.SampleBrowser.UWP.PivotClient.OlapManagerService.IOlapDataProvider>, Syncfusion.SampleBrowser.UWP.PivotClient.OlapManagerService.IOlapDataProvider {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public OlapDataProviderClient() : 
                base(OlapDataProviderClient.GetDefaultBinding(), OlapDataProviderClient.GetDefaultEndpointAddress()) {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IOlapDataProvider.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public OlapDataProviderClient(EndpointConfiguration endpointConfiguration) : 
                base(OlapDataProviderClient.GetBindingForEndpoint(endpointConfiguration), OlapDataProviderClient.GetEndpointAddress(endpointConfiguration)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public OlapDataProviderClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(OlapDataProviderClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public OlapDataProviderClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(OlapDataProviderClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public OlapDataProviderClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Threading.Tasks.Task<string> GetJSONDataAsync(string mDXQuery, string currentReport, bool allowMdxToOlapReportParse) {
            return base.Channel.GetJSONDataAsync(mDXQuery, currentReport, allowMdxToOlapReportParse);
        }
        
        public System.Threading.Tasks.Task<string> GetJSONCubeSchemaAsync(string cubeName) {
            return base.Channel.GetJSONCubeSchemaAsync(cubeName);
        }
        
        public System.Threading.Tasks.Task<string> GetJSONMeasureGroupsDimensionsAsync(string cubeName, string measureGroupName) {
            return base.Channel.GetJSONMeasureGroupsDimensionsAsync(cubeName, measureGroupName);
        }
        
        public System.Threading.Tasks.Task<string> GetJSONParentMemberAsync(string uniqueName, string currentCubeName) {
            return base.Channel.GetJSONParentMemberAsync(uniqueName, currentCubeName);
        }
        
        public System.Threading.Tasks.Task<string> GetJSONCubesAsync() {
            return base.Channel.GetJSONCubesAsync();
        }
        
        public System.Threading.Tasks.Task<string> GetJSONChildMembersAsync(string cubeName, string levelName) {
            return base.Channel.GetJSONChildMembersAsync(cubeName, levelName);
        }
        
        public System.Threading.Tasks.Task<string> GetJSONChildrenByMDXAsync(string command) {
            return base.Channel.GetJSONChildrenByMDXAsync(command);
        }
        
        public System.Threading.Tasks.Task<string> GetJSONDataWithTotalCountAsync(string currentReport) {
            return base.Channel.GetJSONDataWithTotalCountAsync(currentReport);
        }
        
        public System.Threading.Tasks.Task<string> GetJSONLevelMembersUsingMdxAsync(string memberUniqueName, int axisPosition, bool isGrandTotalOn, string cubeName, string pagingParams) {
            return base.Channel.GetJSONLevelMembersUsingMdxAsync(memberUniqueName, axisPosition, isGrandTotalOn, cubeName, pagingParams);
        }
        
        public System.Threading.Tasks.Task<string> GetJSONExecuteMemberCountAsync(string mdxQuery) {
            return base.Channel.GetJSONExecuteMemberCountAsync(mdxQuery);
        }
        
        public System.Threading.Tasks.Task<string> GetJSONExecuteDrillThroughQueryAsync(string mdxQuery) {
            return base.Channel.GetJSONExecuteDrillThroughQueryAsync(mdxQuery);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IOlapDataProvider)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IOlapDataProvider)) {
                return new System.ServiceModel.EndpointAddress("http://bi.syncfusion.com/OlapUWPTestService/OlapManager.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding() {
            return OlapDataProviderClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IOlapDataProvider);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() {
            return OlapDataProviderClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IOlapDataProvider);
        }
        
        public enum EndpointConfiguration {
            
            BasicHttpBinding_IOlapDataProvider,
        }
    }
}
