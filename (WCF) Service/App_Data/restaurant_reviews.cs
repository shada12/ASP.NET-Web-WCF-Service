﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="www.algonquincollege.com/onlineservice/reviews")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="www.algonquincollege.com/onlineservice/reviews", IsNullable=false)]
public partial class restaurants {
    
    private restaurant[] restaurantField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("restaurant")]
    public restaurant[] restaurant {
        get {
            return this.restaurantField;
        }
        set {
            this.restaurantField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="www.algonquincollege.com/onlineservice/reviews")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="www.algonquincollege.com/onlineservice/reviews", IsNullable=false)]
public partial class restaurant {
    
    private string nameField;
    
    private logo logoField;
    
    private AddressType locationField;
    
    private string phoneField;
    
    private int ratingField;
    
    private System.DateTime dateField;
    
    private string reviewerField;
    
    private string summaryField;
    
    private menuitem[] appetizersField;
    
    private menuitem[] entreesField;
    
    /// <remarks/>
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    public logo logo {
        get {
            return this.logoField;
        }
        set {
            this.logoField = value;
        }
    }
    
    /// <remarks/>
    public AddressType location {
        get {
            return this.locationField;
        }
        set {
            this.locationField = value;
        }
    }
    
    /// <remarks/>
    public string phone {
        get {
            return this.phoneField;
        }
        set {
            this.phoneField = value;
        }
    }
    
    /// <remarks/>
    public int rating {
        get {
            return this.ratingField;
        }
        set {
            this.ratingField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime date {
        get {
            return this.dateField;
        }
        set {
            this.dateField = value;
        }
    }
    
    /// <remarks/>
    public string reviewer {
        get {
            return this.reviewerField;
        }
        set {
            this.reviewerField = value;
        }
    }
    
    /// <remarks/>
    public string summary {
        get {
            return this.summaryField;
        }
        set {
            this.summaryField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("menuitem", IsNullable=false)]
    public menuitem[] appetizers {
        get {
            return this.appetizersField;
        }
        set {
            this.appetizersField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("menuitem", IsNullable=false)]
    public menuitem[] entrees {
        get {
            return this.entreesField;
        }
        set {
            this.entreesField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="www.algonquincollege.com/onlineservice/reviews")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="www.algonquincollege.com/onlineservice/reviews", IsNullable=false)]
public partial class logo {
    
    private string nameField;
    
    private string imagefileField;
    
    private imageDimensionType widthField;
    
    private imageDimensionType heightField;
    
    /// <remarks/>
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    public string imagefile {
        get {
            return this.imagefileField;
        }
        set {
            this.imagefileField = value;
        }
    }
    
    /// <remarks/>
    public imageDimensionType width {
        get {
            return this.widthField;
        }
        set {
            this.widthField = value;
        }
    }
    
    /// <remarks/>
    public imageDimensionType height {
        get {
            return this.heightField;
        }
        set {
            this.heightField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="www.algonquincollege.com/onlineservice/reviews")]
public partial class imageDimensionType {
    
    private string unitField;
    
    private int valueField;
    
    public imageDimensionType() {
        this.unitField = "pixel";
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute("pixel")]
    public string unit {
        get {
            return this.unitField;
        }
        set {
            this.unitField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public int Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="www.algonquincollege.com/onlineservice/reviews")]
public partial class PriceType {
    
    private PriceTypeCurrency currencyField;
    
    private int quantityField;
    
    private decimal valueField;
    
    public PriceType() {
        this.quantityField = 1;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public PriceTypeCurrency currency {
        get {
            return this.currencyField;
        }
        set {
            this.currencyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(1)]
    public int quantity {
        get {
            return this.quantityField;
        }
        set {
            this.quantityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public decimal Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="www.algonquincollege.com/onlineservice/reviews")]
public enum PriceTypeCurrency {
    
    /// <remarks/>
    cad,
    
    /// <remarks/>
    usd,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="www.algonquincollege.com/onlineservice/reviews")]
public partial class AddressType {
    
    private string streetField;
    
    private string cityField;
    
    private string provstateField;
    
    private string postalzipcodeField;
    
    /// <remarks/>
    public string street {
        get {
            return this.streetField;
        }
        set {
            this.streetField = value;
        }
    }
    
    /// <remarks/>
    public string city {
        get {
            return this.cityField;
        }
        set {
            this.cityField = value;
        }
    }
    
    /// <remarks/>
    public string provstate {
        get {
            return this.provstateField;
        }
        set {
            this.provstateField = value;
        }
    }
    
    /// <remarks/>
    public string postalzipcode {
        get {
            return this.postalzipcodeField;
        }
        set {
            this.postalzipcodeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="www.algonquincollege.com/onlineservice/reviews")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="www.algonquincollege.com/onlineservice/reviews", IsNullable=false)]
public partial class menuitem {
    
    private string descriptionField;
    
    private PriceType[] priceField;
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("price")]
    public PriceType[] price {
        get {
            return this.priceField;
        }
        set {
            this.priceField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="www.algonquincollege.com/onlineservice/reviews")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="www.algonquincollege.com/onlineservice/reviews", IsNullable=false)]
public partial class appetizers {
    
    private menuitem[] menuitemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("menuitem")]
    public menuitem[] menuitem {
        get {
            return this.menuitemField;
        }
        set {
            this.menuitemField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="www.algonquincollege.com/onlineservice/reviews")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="www.algonquincollege.com/onlineservice/reviews", IsNullable=false)]
public partial class entrees {
    
    private menuitem[] menuitemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("menuitem")]
    public menuitem[] menuitem {
        get {
            return this.menuitemField;
        }
        set {
            this.menuitemField = value;
        }
    }
}
