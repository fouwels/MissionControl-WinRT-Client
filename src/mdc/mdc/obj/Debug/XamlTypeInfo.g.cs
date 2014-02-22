﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace mdc
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
        private global::mdc.mdc_XamlTypeInfo.XamlTypeInfoProvider _provider;

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::mdc.mdc_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            if(_provider == null)
            {
                _provider = new global::mdc.mdc_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(fullName);
        }

        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }
}

namespace mdc.mdc_XamlTypeInfo
{
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByType.TryGetValue(type, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByType(type);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByName.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByName(typeName);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (string.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
            {
                return xamlMember;
            }
            xamlMember = CreateXamlMember(longMemberName);
            if (xamlMember != null)
            {
                _xamlMembers.Add(longMemberName, xamlMember);
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByName = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByType = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>
                _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();

        string[] _typeNameTable = null;
        global::System.Type[] _typeTable = null;

        private void InitTypeTables()
        {
            _typeNameTable = new string[13];
            _typeNameTable[0] = "mdc.Pages.CrunchPage";
            _typeNameTable[1] = "Windows.UI.Xaml.Controls.Page";
            _typeNameTable[2] = "Windows.UI.Xaml.Controls.UserControl";
            _typeNameTable[3] = "mdc.MainPage";
            _typeNameTable[4] = "System.Collections.ObjectModel.ObservableCollection`1<mdc.Templates.SummaryReturn.Root>";
            _typeNameTable[5] = "System.Collections.ObjectModel.Collection`1<mdc.Templates.SummaryReturn.Root>";
            _typeNameTable[6] = "Object";
            _typeNameTable[7] = "mdc.Templates.SummaryReturn.Root";
            _typeNameTable[8] = "String";
            _typeNameTable[9] = "System.Collections.Generic.List`1<mdc.Templates.SummaryReturn.NewsSource>";
            _typeNameTable[10] = "mdc.Templates.SummaryReturn.NewsSource";
            _typeNameTable[11] = "Double";
            _typeNameTable[12] = "mdc.Pages.SubmitCompany";

            _typeTable = new global::System.Type[13];
            _typeTable[0] = typeof(global::mdc.Pages.CrunchPage);
            _typeTable[1] = typeof(global::Windows.UI.Xaml.Controls.Page);
            _typeTable[2] = typeof(global::Windows.UI.Xaml.Controls.UserControl);
            _typeTable[3] = typeof(global::mdc.MainPage);
            _typeTable[4] = typeof(global::System.Collections.ObjectModel.ObservableCollection<global::mdc.Templates.SummaryReturn.Root>);
            _typeTable[5] = typeof(global::System.Collections.ObjectModel.Collection<global::mdc.Templates.SummaryReturn.Root>);
            _typeTable[6] = typeof(global::System.Object);
            _typeTable[7] = typeof(global::mdc.Templates.SummaryReturn.Root);
            _typeTable[8] = typeof(global::System.String);
            _typeTable[9] = typeof(global::System.Collections.Generic.List<global::mdc.Templates.SummaryReturn.NewsSource>);
            _typeTable[10] = typeof(global::mdc.Templates.SummaryReturn.NewsSource);
            _typeTable[11] = typeof(global::System.Double);
            _typeTable[12] = typeof(global::mdc.Pages.SubmitCompany);
        }

        private int LookupTypeIndexByName(string typeName)
        {
            if (_typeNameTable == null)
            {
                InitTypeTables();
            }
            for (int i=0; i<_typeNameTable.Length; i++)
            {
                if(0 == string.CompareOrdinal(_typeNameTable[i], typeName))
                {
                    return i;
                }
            }
            return -1;
        }

        private int LookupTypeIndexByType(global::System.Type type)
        {
            if (_typeTable == null)
            {
                InitTypeTables();
            }
            for(int i=0; i<_typeTable.Length; i++)
            {
                if(type == _typeTable[i])
                {
                    return i;
                }
            }
            return -1;
        }

        private object Activate_0_CrunchPage() { return new global::mdc.Pages.CrunchPage(); }
        private object Activate_3_MainPage() { return new global::mdc.MainPage(); }
        private object Activate_4_ObservableCollection() { return new global::System.Collections.ObjectModel.ObservableCollection<global::mdc.Templates.SummaryReturn.Root>(); }
        private object Activate_5_Collection() { return new global::System.Collections.ObjectModel.Collection<global::mdc.Templates.SummaryReturn.Root>(); }
        private object Activate_9_List() { return new global::System.Collections.Generic.List<global::mdc.Templates.SummaryReturn.NewsSource>(); }
        private object Activate_12_SubmitCompany() { return new global::mdc.Pages.SubmitCompany(); }
        private void VectorAdd_4_ObservableCollection(object instance, object item)
        {
            var collection = (global::System.Collections.Generic.ICollection<global::mdc.Templates.SummaryReturn.Root>)instance;
            var newItem = (global::mdc.Templates.SummaryReturn.Root)item;
            collection.Add(newItem);
        }
        private void VectorAdd_5_Collection(object instance, object item)
        {
            var collection = (global::System.Collections.Generic.ICollection<global::mdc.Templates.SummaryReturn.Root>)instance;
            var newItem = (global::mdc.Templates.SummaryReturn.Root)item;
            collection.Add(newItem);
        }
        private void VectorAdd_9_List(object instance, object item)
        {
            var collection = (global::System.Collections.Generic.ICollection<global::mdc.Templates.SummaryReturn.NewsSource>)instance;
            var newItem = (global::mdc.Templates.SummaryReturn.NewsSource)item;
            collection.Add(newItem);
        }

        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::mdc.mdc_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::mdc.mdc_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  mdc.Pages.CrunchPage
                userType = new global::mdc.mdc_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_0_CrunchPage;
                xamlType = userType;
                break;

            case 1:   //  Windows.UI.Xaml.Controls.Page
                xamlType = new global::mdc.mdc_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 2:   //  Windows.UI.Xaml.Controls.UserControl
                xamlType = new global::mdc.mdc_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 3:   //  mdc.MainPage
                userType = new global::mdc.mdc_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_3_MainPage;
                userType.AddMemberName("CurrentResultItems");
                xamlType = userType;
                break;

            case 4:   //  System.Collections.ObjectModel.ObservableCollection`1<mdc.Templates.SummaryReturn.Root>
                userType = new global::mdc.mdc_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("System.Collections.ObjectModel.Collection`1<mdc.Templates.SummaryReturn.Root>"));
                userType.CollectionAdd = VectorAdd_4_ObservableCollection;
                userType.SetIsReturnTypeStub();
                xamlType = userType;
                break;

            case 5:   //  System.Collections.ObjectModel.Collection`1<mdc.Templates.SummaryReturn.Root>
                userType = new global::mdc.mdc_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_5_Collection;
                userType.CollectionAdd = VectorAdd_5_Collection;
                xamlType = userType;
                break;

            case 6:   //  Object
                xamlType = new global::mdc.mdc_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 7:   //  mdc.Templates.SummaryReturn.Root
                userType = new global::mdc.mdc_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.AddMemberName("company_name");
                userType.AddMemberName("mission_statement");
                userType.AddMemberName("mission_statement_proof");
                userType.AddMemberName("mission_statement_investigator");
                userType.AddMemberName("news_sources");
                xamlType = userType;
                break;

            case 8:   //  String
                xamlType = new global::mdc.mdc_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 9:   //  System.Collections.Generic.List`1<mdc.Templates.SummaryReturn.NewsSource>
                userType = new global::mdc.mdc_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.CollectionAdd = VectorAdd_9_List;
                userType.SetIsReturnTypeStub();
                xamlType = userType;
                break;

            case 10:   //  mdc.Templates.SummaryReturn.NewsSource
                userType = new global::mdc.mdc_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.AddMemberName("name");
                userType.AddMemberName("headline");
                userType.AddMemberName("polarity");
                xamlType = userType;
                break;

            case 11:   //  Double
                xamlType = new global::mdc.mdc_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 12:   //  mdc.Pages.SubmitCompany
                userType = new global::mdc.mdc_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_12_SubmitCompany;
                xamlType = userType;
                break;
            }
            return xamlType;
        }


        private object get_0_MainPage_CurrentResultItems(object instance)
        {
            var that = (global::mdc.MainPage)instance;
            return that.CurrentResultItems;
        }
        private void set_0_MainPage_CurrentResultItems(object instance, object Value)
        {
            var that = (global::mdc.MainPage)instance;
            that.CurrentResultItems = (global::System.Collections.ObjectModel.ObservableCollection<global::mdc.Templates.SummaryReturn.Root>)Value;
        }
        private object get_1_Root_company_name(object instance)
        {
            var that = (global::mdc.Templates.SummaryReturn.Root)instance;
            return that.company_name;
        }
        private void set_1_Root_company_name(object instance, object Value)
        {
            var that = (global::mdc.Templates.SummaryReturn.Root)instance;
            that.company_name = (global::System.String)Value;
        }
        private object get_2_Root_mission_statement(object instance)
        {
            var that = (global::mdc.Templates.SummaryReturn.Root)instance;
            return that.mission_statement;
        }
        private void set_2_Root_mission_statement(object instance, object Value)
        {
            var that = (global::mdc.Templates.SummaryReturn.Root)instance;
            that.mission_statement = (global::System.String)Value;
        }
        private object get_3_Root_mission_statement_proof(object instance)
        {
            var that = (global::mdc.Templates.SummaryReturn.Root)instance;
            return that.mission_statement_proof;
        }
        private void set_3_Root_mission_statement_proof(object instance, object Value)
        {
            var that = (global::mdc.Templates.SummaryReturn.Root)instance;
            that.mission_statement_proof = (global::System.String)Value;
        }
        private object get_4_Root_mission_statement_investigator(object instance)
        {
            var that = (global::mdc.Templates.SummaryReturn.Root)instance;
            return that.mission_statement_investigator;
        }
        private void set_4_Root_mission_statement_investigator(object instance, object Value)
        {
            var that = (global::mdc.Templates.SummaryReturn.Root)instance;
            that.mission_statement_investigator = (global::System.String)Value;
        }
        private object get_5_Root_news_sources(object instance)
        {
            var that = (global::mdc.Templates.SummaryReturn.Root)instance;
            return that.news_sources;
        }
        private void set_5_Root_news_sources(object instance, object Value)
        {
            var that = (global::mdc.Templates.SummaryReturn.Root)instance;
            that.news_sources = (global::System.Collections.Generic.List<global::mdc.Templates.SummaryReturn.NewsSource>)Value;
        }
        private object get_6_NewsSource_name(object instance)
        {
            var that = (global::mdc.Templates.SummaryReturn.NewsSource)instance;
            return that.name;
        }
        private void set_6_NewsSource_name(object instance, object Value)
        {
            var that = (global::mdc.Templates.SummaryReturn.NewsSource)instance;
            that.name = (global::System.String)Value;
        }
        private object get_7_NewsSource_headline(object instance)
        {
            var that = (global::mdc.Templates.SummaryReturn.NewsSource)instance;
            return that.headline;
        }
        private void set_7_NewsSource_headline(object instance, object Value)
        {
            var that = (global::mdc.Templates.SummaryReturn.NewsSource)instance;
            that.headline = (global::System.String)Value;
        }
        private object get_8_NewsSource_polarity(object instance)
        {
            var that = (global::mdc.Templates.SummaryReturn.NewsSource)instance;
            return that.polarity;
        }
        private void set_8_NewsSource_polarity(object instance, object Value)
        {
            var that = (global::mdc.Templates.SummaryReturn.NewsSource)instance;
            that.polarity = (global::System.Double)Value;
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::mdc.mdc_XamlTypeInfo.XamlMember xamlMember = null;
            global::mdc.mdc_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "mdc.MainPage.CurrentResultItems":
                userType = (global::mdc.mdc_XamlTypeInfo.XamlUserType)GetXamlTypeByName("mdc.MainPage");
                xamlMember = new global::mdc.mdc_XamlTypeInfo.XamlMember(this, "CurrentResultItems", "System.Collections.ObjectModel.ObservableCollection`1<mdc.Templates.SummaryReturn.Root>");
                xamlMember.Getter = get_0_MainPage_CurrentResultItems;
                xamlMember.Setter = set_0_MainPage_CurrentResultItems;
                break;
            case "mdc.Templates.SummaryReturn.Root.company_name":
                userType = (global::mdc.mdc_XamlTypeInfo.XamlUserType)GetXamlTypeByName("mdc.Templates.SummaryReturn.Root");
                xamlMember = new global::mdc.mdc_XamlTypeInfo.XamlMember(this, "company_name", "String");
                xamlMember.Getter = get_1_Root_company_name;
                xamlMember.Setter = set_1_Root_company_name;
                break;
            case "mdc.Templates.SummaryReturn.Root.mission_statement":
                userType = (global::mdc.mdc_XamlTypeInfo.XamlUserType)GetXamlTypeByName("mdc.Templates.SummaryReturn.Root");
                xamlMember = new global::mdc.mdc_XamlTypeInfo.XamlMember(this, "mission_statement", "String");
                xamlMember.Getter = get_2_Root_mission_statement;
                xamlMember.Setter = set_2_Root_mission_statement;
                break;
            case "mdc.Templates.SummaryReturn.Root.mission_statement_proof":
                userType = (global::mdc.mdc_XamlTypeInfo.XamlUserType)GetXamlTypeByName("mdc.Templates.SummaryReturn.Root");
                xamlMember = new global::mdc.mdc_XamlTypeInfo.XamlMember(this, "mission_statement_proof", "String");
                xamlMember.Getter = get_3_Root_mission_statement_proof;
                xamlMember.Setter = set_3_Root_mission_statement_proof;
                break;
            case "mdc.Templates.SummaryReturn.Root.mission_statement_investigator":
                userType = (global::mdc.mdc_XamlTypeInfo.XamlUserType)GetXamlTypeByName("mdc.Templates.SummaryReturn.Root");
                xamlMember = new global::mdc.mdc_XamlTypeInfo.XamlMember(this, "mission_statement_investigator", "String");
                xamlMember.Getter = get_4_Root_mission_statement_investigator;
                xamlMember.Setter = set_4_Root_mission_statement_investigator;
                break;
            case "mdc.Templates.SummaryReturn.Root.news_sources":
                userType = (global::mdc.mdc_XamlTypeInfo.XamlUserType)GetXamlTypeByName("mdc.Templates.SummaryReturn.Root");
                xamlMember = new global::mdc.mdc_XamlTypeInfo.XamlMember(this, "news_sources", "System.Collections.Generic.List`1<mdc.Templates.SummaryReturn.NewsSource>");
                xamlMember.Getter = get_5_Root_news_sources;
                xamlMember.Setter = set_5_Root_news_sources;
                break;
            case "mdc.Templates.SummaryReturn.NewsSource.name":
                userType = (global::mdc.mdc_XamlTypeInfo.XamlUserType)GetXamlTypeByName("mdc.Templates.SummaryReturn.NewsSource");
                xamlMember = new global::mdc.mdc_XamlTypeInfo.XamlMember(this, "name", "String");
                xamlMember.Getter = get_6_NewsSource_name;
                xamlMember.Setter = set_6_NewsSource_name;
                break;
            case "mdc.Templates.SummaryReturn.NewsSource.headline":
                userType = (global::mdc.mdc_XamlTypeInfo.XamlUserType)GetXamlTypeByName("mdc.Templates.SummaryReturn.NewsSource");
                xamlMember = new global::mdc.mdc_XamlTypeInfo.XamlMember(this, "headline", "String");
                xamlMember.Getter = get_7_NewsSource_headline;
                xamlMember.Setter = set_7_NewsSource_headline;
                break;
            case "mdc.Templates.SummaryReturn.NewsSource.polarity":
                userType = (global::mdc.mdc_XamlTypeInfo.XamlUserType)GetXamlTypeByName("mdc.Templates.SummaryReturn.NewsSource");
                xamlMember = new global::mdc.mdc_XamlTypeInfo.XamlMember(this, "polarity", "Double");
                xamlMember.Getter = get_8_NewsSource_polarity;
                xamlMember.Setter = set_8_NewsSource_polarity;
                break;
            }
            return xamlMember;
        }
    }

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsReturnTypeStub { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(string input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::mdc.mdc_XamlTypeInfo.XamlSystemBaseType
    {
        global::mdc.mdc_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;
        bool _isReturnTypeStub;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::mdc.mdc_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }
        override public bool IsReturnTypeStub { get { return _isReturnTypeStub; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public object CreateFromString(string input)
        {
            if (_enumValues != null)
            {
                int value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    int enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( string.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetIsReturnTypeStub()
        {
            _isReturnTypeStub = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::mdc.mdc_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::mdc.mdc_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(string targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}


