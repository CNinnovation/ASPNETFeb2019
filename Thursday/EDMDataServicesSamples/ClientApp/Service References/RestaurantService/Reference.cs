//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.21006.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name:
// Generation date: 12/3/2009 11:42:59 PM
namespace Wrox.ProCSharp.DataServices.RestaurantService.RestaurantModel
{
    
    /// <summary>
    /// There are no comments for RestaurantEntities in the schema.
    /// </summary>
    public partial class RestaurantEntities : global::System.Data.Services.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new RestaurantEntities object.
        /// </summary>
        public RestaurantEntities(global::System.Uri serviceRoot) : 
                base(serviceRoot)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.EntityModel.Emitters.EntityContainerEmitter", "1.0.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            if (typeName.StartsWith("RestaurantModel", global::System.StringComparison.Ordinal))
            {
                return this.GetType().Assembly.GetType(string.Concat("Wrox.ProCSharp.DataServices.RestaurantService.RestaurantModel", typeName.Substring(15)), false);
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.EntityModel.Emitters.EntityContainerEmitter", "1.0.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            if (clientType.Namespace.Equals("Wrox.ProCSharp.DataServices.RestaurantService.RestaurantModel", global::System.StringComparison.Ordinal))
            {
                return string.Concat("RestaurantModel.", clientType.Name);
            }
            return null;
        }
        /// <summary>
        /// There are no comments for Categories in the schema.
        /// </summary>
        public global::System.Data.Services.Client.DataServiceQuery<Category> Categories
        {
            get
            {
                if ((this._Categories == null))
                {
                    this._Categories = base.CreateQuery<Category>("Categories");
                }
                return this._Categories;
            }
        }
        private global::System.Data.Services.Client.DataServiceQuery<Category> _Categories;
        /// <summary>
        /// There are no comments for Menus in the schema.
        /// </summary>
        public global::System.Data.Services.Client.DataServiceQuery<Menu> Menus
        {
            get
            {
                if ((this._Menus == null))
                {
                    this._Menus = base.CreateQuery<Menu>("Menus");
                }
                return this._Menus;
            }
        }
        private global::System.Data.Services.Client.DataServiceQuery<Menu> _Menus;
        /// <summary>
        /// There are no comments for Categories in the schema.
        /// </summary>
        public void AddToCategories(Category category)
        {
            base.AddObject("Categories", category);
        }
        /// <summary>
        /// There are no comments for Menus in the schema.
        /// </summary>
        public void AddToMenus(Menu menu)
        {
            base.AddObject("Menus", menu);
        }
    }
    /// <summary>
    /// There are no comments for RestaurantModel.Category in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Categories")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class Category : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Category object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        /// <param name="name">Initial value of Name.</param>
        public static Category CreateCategory(int ID, string name)
        {
            Category category = new Category();
            category.Id = ID;
            category.Name = name;
            return category;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Menus in the schema.
        /// </summary>
        public global::System.Data.Services.Client.DataServiceCollection<Menu> Menus
        {
            get
            {
                return this._Menus;
            }
            set
            {
                this._Menus = value;
                this.OnPropertyChanged("Menus");
            }
        }
        private global::System.Data.Services.Client.DataServiceCollection<Menu> _Menus = System.Data.Services.Client.DataServiceCollection.Create<Menu>();
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for RestaurantModel.Menu in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Menus")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class Menu : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Menu object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        /// <param name="categoryId">Initial value of CategoryId.</param>
        /// <param name="name">Initial value of Name.</param>
        /// <param name="active">Initial value of Active.</param>
        public static Menu CreateMenu(int ID, int categoryId, string name, bool active)
        {
            Menu menu = new Menu();
            menu.Id = ID;
            menu.CategoryId = categoryId;
            menu.Name = name;
            menu.Active = active;
            return menu;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property CategoryId in the schema.
        /// </summary>
        public int CategoryId
        {
            get
            {
                return this._CategoryId;
            }
            set
            {
                this.OnCategoryIdChanging(value);
                this._CategoryId = value;
                this.OnCategoryIdChanged();
                this.OnPropertyChanged("CategoryId");
            }
        }
        private int _CategoryId;
        partial void OnCategoryIdChanging(int value);
        partial void OnCategoryIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property Active in the schema.
        /// </summary>
        public bool Active
        {
            get
            {
                return this._Active;
            }
            set
            {
                this.OnActiveChanging(value);
                this._Active = value;
                this.OnActiveChanged();
                this.OnPropertyChanged("Active");
            }
        }
        private bool _Active;
        partial void OnActiveChanging(bool value);
        partial void OnActiveChanged();
        /// <summary>
        /// There are no comments for Property Price in the schema.
        /// </summary>
        public global::System.Nullable<decimal> Price
        {
            get
            {
                return this._Price;
            }
            set
            {
                this.OnPriceChanging(value);
                this._Price = value;
                this.OnPriceChanged();
                this.OnPropertyChanged("Price");
            }
        }
        private global::System.Nullable<decimal> _Price;
        partial void OnPriceChanging(global::System.Nullable<decimal> value);
        partial void OnPriceChanged();
        /// <summary>
        /// There are no comments for Category in the schema.
        /// </summary>
        public Category Category
        {
            get
            {
                return this._Category;
            }
            set
            {
                this._Category = value;
                this.OnPropertyChanged("Category");
            }
        }
        private Category _Category;
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}
