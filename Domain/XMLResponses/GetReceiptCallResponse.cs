﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.Xml.Serialization;

namespace ShoeboxedService.Domain.XMLResponses
{ // 
// This source code was auto-generated by xsd, Version=4.0.30319.1.
// 


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class GetReceiptCallResponse {
    
        private GetReceiptCallResponseReceipts[] itemsField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Receipts", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GetReceiptCallResponseReceipts[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class GetReceiptCallResponseReceipts {
    
        private GetReceiptCallResponseReceiptsReceipt[] receiptField;
    
        private string countField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Receipt", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GetReceiptCallResponseReceiptsReceipt[] Receipt {
            get {
                return this.receiptField;
            }
            set {
                this.receiptField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class GetReceiptCallResponseReceiptsReceipt {
    
        private GetReceiptCallResponseReceiptsReceiptImagesImage[] imagesField;
    
        private GetReceiptCallResponseReceiptsReceiptCategoriesCategory[] categoriesField;
    
        private string storeField;
    
        private string idField;
    
        private string totalField;
    
        private string documentCurrencyField;
    
        private string accountCurrencyField;
    
        private string conversionRateField;
    
        private string documentTotalField;
    
        private string convertedTotalField;
    
        private string formattedDocumentTotalField;
    
        private string formattedConvertedTotalField;
    
        private string documentTaxField;
    
        private string convertedTaxField;
    
        private string formattedDocumentTaxField;
    
        private string formattedConvertedTaxField;
    
        private string dateField;
    
        private string modifiedDateField;
    
        private string createdDateField;
    
        private string selldateField;
    
        private string imgurlField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Image", typeof(GetReceiptCallResponseReceiptsReceiptImagesImage), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public GetReceiptCallResponseReceiptsReceiptImagesImage[] Images {
            get {
                return this.imagesField;
            }
            set {
                this.imagesField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Category", typeof(GetReceiptCallResponseReceiptsReceiptCategoriesCategory), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public GetReceiptCallResponseReceiptsReceiptCategoriesCategory[] Categories {
            get {
                return this.categoriesField;
            }
            set {
                this.categoriesField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string store {
            get {
                return this.storeField;
            }
            set {
                this.storeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string total {
            get {
                return this.totalField;
            }
            set {
                this.totalField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string documentCurrency {
            get {
                return this.documentCurrencyField;
            }
            set {
                this.documentCurrencyField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string accountCurrency {
            get {
                return this.accountCurrencyField;
            }
            set {
                this.accountCurrencyField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string conversionRate {
            get {
                return this.conversionRateField;
            }
            set {
                this.conversionRateField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string documentTotal {
            get {
                return this.documentTotalField;
            }
            set {
                this.documentTotalField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string convertedTotal {
            get {
                return this.convertedTotalField;
            }
            set {
                this.convertedTotalField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string formattedDocumentTotal {
            get {
                return this.formattedDocumentTotalField;
            }
            set {
                this.formattedDocumentTotalField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string formattedConvertedTotal {
            get {
                return this.formattedConvertedTotalField;
            }
            set {
                this.formattedConvertedTotalField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string documentTax {
            get {
                return this.documentTaxField;
            }
            set {
                this.documentTaxField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string convertedTax {
            get {
                return this.convertedTaxField;
            }
            set {
                this.convertedTaxField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string formattedDocumentTax {
            get {
                return this.formattedDocumentTaxField;
            }
            set {
                this.formattedDocumentTaxField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string formattedConvertedTax {
            get {
                return this.formattedConvertedTaxField;
            }
            set {
                this.formattedConvertedTaxField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string date {
            get {
                return this.dateField;
            }
            set {
                this.dateField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string modifiedDate {
            get {
                return this.modifiedDateField;
            }
            set {
                this.modifiedDateField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string createdDate {
            get {
                return this.createdDateField;
            }
            set {
                this.createdDateField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string selldate {
            get {
                return this.selldateField;
            }
            set {
                this.selldateField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string imgurl {
            get {
                return this.imgurlField;
            }
            set {
                this.imgurlField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class GetReceiptCallResponseReceiptsReceiptImagesImage {
    
        private string imgurlField;
    
        private string indexField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string imgurl {
            get {
                return this.imgurlField;
            }
            set {
                this.imgurlField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string index {
            get {
                return this.indexField;
            }
            set {
                this.indexField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class GetReceiptCallResponseReceiptsReceiptCategoriesCategory {
    
        private string nameField;
    
        private string idField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
}