﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.9043
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.CompactFramework.Design.Data, Version 2.0.50727.9043.
// 
namespace Calbee.WMS.Services.CountService {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_ICountService", Namespace="http://tempuri.org/")]
    public partial class CountService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public CountService() {
            this.Url = "http://43.229.78.24/WMSService/CountService.svc";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ICountService/GetCounts", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/WMS.Service.Models.Transaction.Count")]
        public tbt_Count[] GetCounts([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string warehouse_code, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string count_number) {
            object[] results = this.Invoke("GetCounts", new object[] {
                        warehouse_code,
                        count_number});
            return ((tbt_Count[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetCounts(string warehouse_code, string count_number, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetCounts", new object[] {
                        warehouse_code,
                        count_number}, callback, asyncState);
        }
        
        /// <remarks/>
        public tbt_Count[] EndGetCounts(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((tbt_Count[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ICountService/GetCountNumbers", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string[] GetCountNumbers([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string warehouse_code) {
            object[] results = this.Invoke("GetCountNumbers", new object[] {
                        warehouse_code});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetCountNumbers(string warehouse_code, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetCountNumbers", new object[] {
                        warehouse_code}, callback, asyncState);
        }
        
        /// <remarks/>
        public string[] EndGetCountNumbers(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ICountService/GetCountDetail", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/WMS.Service.Models.Transaction.Count")]
        public CountDetail[] GetCountDetail([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string warehouse_code, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string count_number, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string location_code, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string lpn, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string item_number) {
            object[] results = this.Invoke("GetCountDetail", new object[] {
                        warehouse_code,
                        count_number,
                        location_code,
                        lpn,
                        item_number});
            return ((CountDetail[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetCountDetail(string warehouse_code, string count_number, string location_code, string lpn, string item_number, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetCountDetail", new object[] {
                        warehouse_code,
                        count_number,
                        location_code,
                        lpn,
                        item_number}, callback, asyncState);
        }
        
        /// <remarks/>
        public CountDetail[] EndGetCountDetail(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((CountDetail[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ICountService/SetCountItem", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Response SetCountItem([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] CountItem count_item) {
            object[] results = this.Invoke("SetCountItem", new object[] {
                        count_item});
            return ((Response)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginSetCountItem(CountItem count_item, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("SetCountItem", new object[] {
                        count_item}, callback, asyncState);
        }
        
        /// <remarks/>
        public Response EndSetCountItem(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((Response)(results[0]));
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/WMS.Service.Models.Transaction.Count")]
    public partial class tbt_Count {
        
        private System.DateTime countDateField;
        
        private bool countDateFieldSpecified;
        
        private long countIdField;
        
        private bool countIdFieldSpecified;
        
        private string countNumberField;
        
        private string countStatusField;
        
        private string countTypeField;
        
        private tbm_Warehouse warehouseField;
        
        private int warehouseIdField;
        
        private bool warehouseIdFieldSpecified;
        
        /// <remarks/>
        public System.DateTime CountDate {
            get {
                return this.countDateField;
            }
            set {
                this.countDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CountDateSpecified {
            get {
                return this.countDateFieldSpecified;
            }
            set {
                this.countDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public long CountId {
            get {
                return this.countIdField;
            }
            set {
                this.countIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CountIdSpecified {
            get {
                return this.countIdFieldSpecified;
            }
            set {
                this.countIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string CountNumber {
            get {
                return this.countNumberField;
            }
            set {
                this.countNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string CountStatus {
            get {
                return this.countStatusField;
            }
            set {
                this.countStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string CountType {
            get {
                return this.countTypeField;
            }
            set {
                this.countTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public tbm_Warehouse Warehouse {
            get {
                return this.warehouseField;
            }
            set {
                this.warehouseField = value;
            }
        }
        
        /// <remarks/>
        public int WarehouseId {
            get {
                return this.warehouseIdField;
            }
            set {
                this.warehouseIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WarehouseIdSpecified {
            get {
                return this.warehouseIdFieldSpecified;
            }
            set {
                this.warehouseIdFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/WMS.Service.Models.Master")]
    public partial class tbm_Warehouse {
        
        private bool isActiveField;
        
        private bool isActiveFieldSpecified;
        
        private string warehouseCodeField;
        
        private int warehouseIdField;
        
        private bool warehouseIdFieldSpecified;
        
        private string warehouseNameField;
        
        /// <remarks/>
        public bool IsActive {
            get {
                return this.isActiveField;
            }
            set {
                this.isActiveField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsActiveSpecified {
            get {
                return this.isActiveFieldSpecified;
            }
            set {
                this.isActiveFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string WarehouseCode {
            get {
                return this.warehouseCodeField;
            }
            set {
                this.warehouseCodeField = value;
            }
        }
        
        /// <remarks/>
        public int WarehouseId {
            get {
                return this.warehouseIdField;
            }
            set {
                this.warehouseIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WarehouseIdSpecified {
            get {
                return this.warehouseIdFieldSpecified;
            }
            set {
                this.warehouseIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string WarehouseName {
            get {
                return this.warehouseNameField;
            }
            set {
                this.warehouseNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/WMS.Service.Models.Responses")]
    public partial class Response {
        
        private string messageField;
        
        private int statusCodeField;
        
        private bool statusCodeFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }
        
        /// <remarks/>
        public int StatusCode {
            get {
                return this.statusCodeField;
            }
            set {
                this.statusCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StatusCodeSpecified {
            get {
                return this.statusCodeFieldSpecified;
            }
            set {
                this.statusCodeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/WMS.Service.Models.Transaction.Count")]
    public partial class CountItem {
        
        private string countByField;
        
        private string countDateField;
        
        private string countNumberField;
        
        private double countQtyField;
        
        private bool countQtyFieldSpecified;
        
        private string deviceField;
        
        private string expiryDateField;
        
        private string itemNameField;
        
        private string itemNumberField;
        
        private string lPNField;
        
        private string locationField;
        
        private string lotNumberField;
        
        private string parentLPNField;
        
        private string plantCodeField;
        
        private string serialNumberField;
        
        private string statusField;
        
        private string uomField;
        
        private string warehouseCodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string CountBy {
            get {
                return this.countByField;
            }
            set {
                this.countByField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string CountDate {
            get {
                return this.countDateField;
            }
            set {
                this.countDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string CountNumber {
            get {
                return this.countNumberField;
            }
            set {
                this.countNumberField = value;
            }
        }
        
        /// <remarks/>
        public double CountQty {
            get {
                return this.countQtyField;
            }
            set {
                this.countQtyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CountQtySpecified {
            get {
                return this.countQtyFieldSpecified;
            }
            set {
                this.countQtyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Device {
            get {
                return this.deviceField;
            }
            set {
                this.deviceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string ExpiryDate {
            get {
                return this.expiryDateField;
            }
            set {
                this.expiryDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string ItemName {
            get {
                return this.itemNameField;
            }
            set {
                this.itemNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string ItemNumber {
            get {
                return this.itemNumberField;
            }
            set {
                this.itemNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string LPN {
            get {
                return this.lPNField;
            }
            set {
                this.lPNField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string LotNumber {
            get {
                return this.lotNumberField;
            }
            set {
                this.lotNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string ParentLPN {
            get {
                return this.parentLPNField;
            }
            set {
                this.parentLPNField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string PlantCode {
            get {
                return this.plantCodeField;
            }
            set {
                this.plantCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string SerialNumber {
            get {
                return this.serialNumberField;
            }
            set {
                this.serialNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Uom {
            get {
                return this.uomField;
            }
            set {
                this.uomField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string WarehouseCode {
            get {
                return this.warehouseCodeField;
            }
            set {
                this.warehouseCodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/WMS.Service.Models.Transaction.Count")]
    public partial class CountDetail {
        
        private string alternateItemNumberField;
        
        private long countDetailIdField;
        
        private bool countDetailIdFieldSpecified;
        
        private long countIdField;
        
        private bool countIdFieldSpecified;
        
        private System.Nullable<double> countQtyField;
        
        private bool countQtyFieldSpecified;
        
        private string crossRefUomField;
        
        private string expiryDateField;
        
        private bool expiryDateControlField;
        
        private bool expiryDateControlFieldSpecified;
        
        private int itemIdField;
        
        private bool itemIdFieldSpecified;
        
        private string itemNameField;
        
        private string itemNumberField;
        
        private string itemStatusField;
        
        private int lineNumberField;
        
        private bool lineNumberFieldSpecified;
        
        private int locationIdField;
        
        private bool locationIdFieldSpecified;
        
        private bool lotControlField;
        
        private bool lotControlFieldSpecified;
        
        private string lotNumberField;
        
        private string lpnField;
        
        private string parentLpnField;
        
        private bool serialControlField;
        
        private bool serialControlFieldSpecified;
        
        private string serialNumberField;
        
        private int statusIdField;
        
        private bool statusIdFieldSpecified;
        
        private System.Nullable<double> stockQtyField;
        
        private bool stockQtyFieldSpecified;
        
        private string uomField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string AlternateItemNumber {
            get {
                return this.alternateItemNumberField;
            }
            set {
                this.alternateItemNumberField = value;
            }
        }
        
        /// <remarks/>
        public long CountDetailId {
            get {
                return this.countDetailIdField;
            }
            set {
                this.countDetailIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CountDetailIdSpecified {
            get {
                return this.countDetailIdFieldSpecified;
            }
            set {
                this.countDetailIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public long CountId {
            get {
                return this.countIdField;
            }
            set {
                this.countIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CountIdSpecified {
            get {
                return this.countIdFieldSpecified;
            }
            set {
                this.countIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<double> CountQty {
            get {
                return this.countQtyField;
            }
            set {
                this.countQtyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CountQtySpecified {
            get {
                return this.countQtyFieldSpecified;
            }
            set {
                this.countQtyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string CrossRefUom {
            get {
                return this.crossRefUomField;
            }
            set {
                this.crossRefUomField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string ExpiryDate {
            get {
                return this.expiryDateField;
            }
            set {
                this.expiryDateField = value;
            }
        }
        
        /// <remarks/>
        public bool ExpiryDateControl {
            get {
                return this.expiryDateControlField;
            }
            set {
                this.expiryDateControlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExpiryDateControlSpecified {
            get {
                return this.expiryDateControlFieldSpecified;
            }
            set {
                this.expiryDateControlFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int ItemId {
            get {
                return this.itemIdField;
            }
            set {
                this.itemIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ItemIdSpecified {
            get {
                return this.itemIdFieldSpecified;
            }
            set {
                this.itemIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string ItemName {
            get {
                return this.itemNameField;
            }
            set {
                this.itemNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string ItemNumber {
            get {
                return this.itemNumberField;
            }
            set {
                this.itemNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string ItemStatus {
            get {
                return this.itemStatusField;
            }
            set {
                this.itemStatusField = value;
            }
        }
        
        /// <remarks/>
        public int LineNumber {
            get {
                return this.lineNumberField;
            }
            set {
                this.lineNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LineNumberSpecified {
            get {
                return this.lineNumberFieldSpecified;
            }
            set {
                this.lineNumberFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int LocationId {
            get {
                return this.locationIdField;
            }
            set {
                this.locationIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LocationIdSpecified {
            get {
                return this.locationIdFieldSpecified;
            }
            set {
                this.locationIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool LotControl {
            get {
                return this.lotControlField;
            }
            set {
                this.lotControlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LotControlSpecified {
            get {
                return this.lotControlFieldSpecified;
            }
            set {
                this.lotControlFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string LotNumber {
            get {
                return this.lotNumberField;
            }
            set {
                this.lotNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Lpn {
            get {
                return this.lpnField;
            }
            set {
                this.lpnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string ParentLpn {
            get {
                return this.parentLpnField;
            }
            set {
                this.parentLpnField = value;
            }
        }
        
        /// <remarks/>
        public bool SerialControl {
            get {
                return this.serialControlField;
            }
            set {
                this.serialControlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SerialControlSpecified {
            get {
                return this.serialControlFieldSpecified;
            }
            set {
                this.serialControlFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string SerialNumber {
            get {
                return this.serialNumberField;
            }
            set {
                this.serialNumberField = value;
            }
        }
        
        /// <remarks/>
        public int StatusId {
            get {
                return this.statusIdField;
            }
            set {
                this.statusIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StatusIdSpecified {
            get {
                return this.statusIdFieldSpecified;
            }
            set {
                this.statusIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<double> StockQty {
            get {
                return this.stockQtyField;
            }
            set {
                this.stockQtyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StockQtySpecified {
            get {
                return this.stockQtyFieldSpecified;
            }
            set {
                this.stockQtyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Uom {
            get {
                return this.uomField;
            }
            set {
                this.uomField = value;
            }
        }
    }
}