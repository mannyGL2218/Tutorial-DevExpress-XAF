using CreacionTest.Module.BusinessObjects.Catalogos;
using CreacionTest.Module.Enumerados;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace CreacionTest.Module.BusinessObjects.Pruebas
{
    [DefaultClassOptions]
    [NavigationItem("Pruebas")]
    [XafDisplayName("PELÍCULAS")]
    [DefaultProperty("Titulo")]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Peliculas : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Peliculas(Session session)
            : base(session)
        {
        }
        
        /*
        private string _PersistentProperty;
        [XafDisplayName("My display name"), ToolTip("My hint message")
        public string PersistentProperty {
            get { return _PersistentProperty; }
            set { SetPropertyValue(nameof(PersistentProperty), ref _PersistentProperty, value); }
        }*/
        #region Propiedades
        private string _Titulo;
        [XafDisplayName("Título"), ToolTip("Título de la película")]
        [RuleRequiredField]
        public string Titulo
        {
            get { return _Titulo; }
            set { SetPropertyValue(nameof(Titulo), ref _Titulo, value);  }
        }
        private string _Sinopsis;
        [XafDisplayName("Sinopsis"), ToolTip("Sinopsis de la película")]
        [VisibleInListView(false)]
        [Size(500)]
        public string Sinopsis
        {
            get { return _Sinopsis; }
            set { SetPropertyValue(nameof(Sinopsis), ref _Sinopsis, value); }
        }
        private DateTime _FechaDePublicacion;
        [XafDisplayName("Fecha de publicacion"), ToolTip("Fecha de publicacion de la película")]
        [VisibleInListView(false)]
        public DateTime FechaDePublicacion
        {
            get { return _FechaDePublicacion; }
            set { SetPropertyValue(nameof(FechaDePublicacion), ref _FechaDePublicacion, value); }
        }

        private double _Precio;
        [XafDisplayName("Precio"), ToolTip("Precio de la película")]
        public double Precio
        {
            get { return _Precio; }
            set { SetPropertyValue(nameof(Precio), ref _Precio, value); }
        }
        private FileData _Pelicula;
        [XafDisplayName("Pelicula")]
        [VisibleInListView(false)]
        public FileData Pelicula
        {
            get { return _Pelicula; }
            set { SetPropertyValue(nameof(Pelicula), ref _Pelicula, value); }
        }
        
        private bool _Visible;
        [XafDisplayName("Visible")]
        public bool Visible
        {
            get { return _Visible; }
            set { SetPropertyValue(nameof(Visible), ref _Visible, value); }
        }
        #endregion

        #region Asociaciones
        private CAT_GENEROS_PELICULAS _Cat_Genero;
        [XafDisplayName("Género"), ToolTip("Género de la película")]
        [DataSourceCriteria("Visible = true")]
        public CAT_GENEROS_PELICULAS Cat_Genero
        {
            get { return _Cat_Genero; }
            set { SetPropertyValue(nameof(Cat_Genero), ref _Cat_Genero, value); }
        }

        private EN_TIPO_PELICULA _TipoDePelicula;
        [XafDisplayName("Tipo De Pelicula")]
        public EN_TIPO_PELICULA TipoDePelicula
        {
            get { return _TipoDePelicula; }
            set { SetPropertyValue(nameof(TipoDePelicula), ref _TipoDePelicula, value); }
        }
        #endregion

        #region Metodos
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            this.Visible = true;
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        /*
        [Action(Caption = "Visible/Invisible", ConfirmationMessage ="¿Estás seguro?", AutoCommit = true)]
        public void Visibilidad() {
            // Trigger a custom business logic for the current record in the UI (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112619.aspx).
            this.Visible = !this.Visible;
        }*/
        #endregion
        //[ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)]
        //[Persistent("DatabaseColumnName"), RuleRequiredField(DefaultContexts.Save)]

        //[Action(Caption = "My UI Action", ConfirmationMessage = "Are you sure?", ImageName = "Attention", AutoCommit = true)]
        //public void ActionMethod() {
        //    // Trigger a custom business logic for the current record in the UI (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112619.aspx).
        //    this.PersistentProperty = "Paid";
        //}
    }
}