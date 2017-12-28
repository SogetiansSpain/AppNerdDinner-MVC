﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region Metadatos de relaciones en EDM

[assembly: EdmRelationshipAttribute("NerdDinnerModel", "FK_RSVP_Dinners", "Dinners", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(NerdDinner.Models.Dinner), "RSVP", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(NerdDinner.Models.RSVP), true)]

#endregion

namespace NerdDinner.Models
{
    #region Contextos
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    public partial class NerdDinnerEntities : ObjectContext
    {
        #region Constructores
    
        /// <summary>
        /// Inicializa un nuevo objeto NerdDinnerEntities usando la cadena de conexión encontrada en la sección 'NerdDinnerEntities' del archivo de configuración de la aplicación.
        /// </summary>
        public NerdDinnerEntities() : base("name=NerdDinnerEntities", "NerdDinnerEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto NerdDinnerEntities.
        /// </summary>
        public NerdDinnerEntities(string connectionString) : base(connectionString, "NerdDinnerEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto NerdDinnerEntities.
        /// </summary>
        public NerdDinnerEntities(EntityConnection connection) : base(connection, "NerdDinnerEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Métodos parciales
    
        partial void OnContextCreated();
    
        #endregion
    
        #region Propiedades de ObjectSet
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<Dinner> Dinners
        {
            get
            {
                if ((_Dinners == null))
                {
                    _Dinners = base.CreateObjectSet<Dinner>("Dinners");
                }
                return _Dinners;
            }
        }
        private ObjectSet<Dinner> _Dinners;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<RSVP> RSVPs
        {
            get
            {
                if ((_RSVPs == null))
                {
                    _RSVPs = base.CreateObjectSet<RSVP>("RSVPs");
                }
                return _RSVPs;
            }
        }
        private ObjectSet<RSVP> _RSVPs;

        #endregion

        #region Métodos AddTo
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Dinners. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToDinners(Dinner dinner)
        {
            base.AddObject("Dinners", dinner);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet RSVPs. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToRSVPs(RSVP rSVP)
        {
            base.AddObject("RSVPs", rSVP);
        }

        #endregion

    }

    #endregion

    #region Entidades
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="NerdDinnerModel", Name="Dinner")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Dinner : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto Dinner.
        /// </summary>
        /// <param name="dinnerID">Valor inicial de la propiedad DinnerID.</param>
        /// <param name="title">Valor inicial de la propiedad Title.</param>
        /// <param name="eventDate">Valor inicial de la propiedad EventDate.</param>
        /// <param name="description">Valor inicial de la propiedad Description.</param>
        /// <param name="hostedBy">Valor inicial de la propiedad HostedBy.</param>
        /// <param name="contactPhone">Valor inicial de la propiedad ContactPhone.</param>
        /// <param name="address">Valor inicial de la propiedad Address.</param>
        /// <param name="country">Valor inicial de la propiedad Country.</param>
        /// <param name="latitude">Valor inicial de la propiedad Latitude.</param>
        /// <param name="longitude">Valor inicial de la propiedad Longitude.</param>
        public static Dinner CreateDinner(global::System.Int32 dinnerID, global::System.String title, global::System.DateTime eventDate, global::System.String description, global::System.String hostedBy, global::System.String contactPhone, global::System.String address, global::System.String country, global::System.Double latitude, global::System.Double longitude)
        {
            Dinner dinner = new Dinner();
            dinner.DinnerID = dinnerID;
            dinner.Title = title;
            dinner.EventDate = eventDate;
            dinner.Description = description;
            dinner.HostedBy = hostedBy;
            dinner.ContactPhone = contactPhone;
            dinner.Address = address;
            dinner.Country = country;
            dinner.Latitude = latitude;
            dinner.Longitude = longitude;
            return dinner;
        }

        #endregion

        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 DinnerID
        {
            get
            {
                return _DinnerID;
            }
            set
            {
                if (_DinnerID != value)
                {
                    OnDinnerIDChanging(value);
                    ReportPropertyChanging("DinnerID");
                    _DinnerID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("DinnerID");
                    OnDinnerIDChanged();
                }
            }
        }
        private global::System.Int32 _DinnerID;
        partial void OnDinnerIDChanging(global::System.Int32 value);
        partial void OnDinnerIDChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime EventDate
        {
            get
            {
                return _EventDate;
            }
            set
            {
                OnEventDateChanging(value);
                ReportPropertyChanging("EventDate");
                _EventDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("EventDate");
                OnEventDateChanged();
            }
        }
        private global::System.DateTime _EventDate;
        partial void OnEventDateChanging(global::System.DateTime value);
        partial void OnEventDateChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String HostedBy
        {
            get
            {
                return _HostedBy;
            }
            set
            {
                OnHostedByChanging(value);
                ReportPropertyChanging("HostedBy");
                _HostedBy = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("HostedBy");
                OnHostedByChanged();
            }
        }
        private global::System.String _HostedBy;
        partial void OnHostedByChanging(global::System.String value);
        partial void OnHostedByChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ContactPhone
        {
            get
            {
                return _ContactPhone;
            }
            set
            {
                OnContactPhoneChanging(value);
                ReportPropertyChanging("ContactPhone");
                _ContactPhone = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ContactPhone");
                OnContactPhoneChanged();
            }
        }
        private global::System.String _ContactPhone;
        partial void OnContactPhoneChanging(global::System.String value);
        partial void OnContactPhoneChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Address
        {
            get
            {
                return _Address;
            }
            set
            {
                OnAddressChanging(value);
                ReportPropertyChanging("Address");
                _Address = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Address");
                OnAddressChanged();
            }
        }
        private global::System.String _Address;
        partial void OnAddressChanging(global::System.String value);
        partial void OnAddressChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Country
        {
            get
            {
                return _Country;
            }
            set
            {
                OnCountryChanging(value);
                ReportPropertyChanging("Country");
                _Country = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Country");
                OnCountryChanged();
            }
        }
        private global::System.String _Country;
        partial void OnCountryChanging(global::System.String value);
        partial void OnCountryChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double Latitude
        {
            get
            {
                return _Latitude;
            }
            set
            {
                OnLatitudeChanging(value);
                ReportPropertyChanging("Latitude");
                _Latitude = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Latitude");
                OnLatitudeChanged();
            }
        }
        private global::System.Double _Latitude;
        partial void OnLatitudeChanging(global::System.Double value);
        partial void OnLatitudeChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double Longitude
        {
            get
            {
                return _Longitude;
            }
            set
            {
                OnLongitudeChanging(value);
                ReportPropertyChanging("Longitude");
                _Longitude = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Longitude");
                OnLongitudeChanged();
            }
        }
        private global::System.Double _Longitude;
        partial void OnLongitudeChanging(global::System.Double value);
        partial void OnLongitudeChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String HostedById
        {
            get
            {
                return _HostedById;
            }
            set
            {
                OnHostedByIdChanging(value);
                ReportPropertyChanging("HostedById");
                _HostedById = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("HostedById");
                OnHostedByIdChanged();
            }
        }
        private global::System.String _HostedById;
        partial void OnHostedByIdChanging(global::System.String value);
        partial void OnHostedByIdChanged();

        #endregion

    
        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("NerdDinnerModel", "FK_RSVP_Dinners", "RSVP")]
        public EntityCollection<RSVP> RSVPs
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<RSVP>("NerdDinnerModel.FK_RSVP_Dinners", "RSVP");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<RSVP>("NerdDinnerModel.FK_RSVP_Dinners", "RSVP", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="NerdDinnerModel", Name="RSVP")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class RSVP : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto RSVP.
        /// </summary>
        /// <param name="rsvpID">Valor inicial de la propiedad RsvpID.</param>
        /// <param name="dinnerID">Valor inicial de la propiedad DinnerID.</param>
        /// <param name="attendeeName">Valor inicial de la propiedad AttendeeName.</param>
        public static RSVP CreateRSVP(global::System.Int32 rsvpID, global::System.Int32 dinnerID, global::System.String attendeeName)
        {
            RSVP rSVP = new RSVP();
            rSVP.RsvpID = rsvpID;
            rSVP.DinnerID = dinnerID;
            rSVP.AttendeeName = attendeeName;
            return rSVP;
        }

        #endregion

        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 RsvpID
        {
            get
            {
                return _RsvpID;
            }
            set
            {
                if (_RsvpID != value)
                {
                    OnRsvpIDChanging(value);
                    ReportPropertyChanging("RsvpID");
                    _RsvpID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("RsvpID");
                    OnRsvpIDChanged();
                }
            }
        }
        private global::System.Int32 _RsvpID;
        partial void OnRsvpIDChanging(global::System.Int32 value);
        partial void OnRsvpIDChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 DinnerID
        {
            get
            {
                return _DinnerID;
            }
            set
            {
                OnDinnerIDChanging(value);
                ReportPropertyChanging("DinnerID");
                _DinnerID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DinnerID");
                OnDinnerIDChanged();
            }
        }
        private global::System.Int32 _DinnerID;
        partial void OnDinnerIDChanging(global::System.Int32 value);
        partial void OnDinnerIDChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String AttendeeName
        {
            get
            {
                return _AttendeeName;
            }
            set
            {
                OnAttendeeNameChanging(value);
                ReportPropertyChanging("AttendeeName");
                _AttendeeName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("AttendeeName");
                OnAttendeeNameChanged();
            }
        }
        private global::System.String _AttendeeName;
        partial void OnAttendeeNameChanging(global::System.String value);
        partial void OnAttendeeNameChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String AttendeeNameId
        {
            get
            {
                return _AttendeeNameId;
            }
            set
            {
                OnAttendeeNameIdChanging(value);
                ReportPropertyChanging("AttendeeNameId");
                _AttendeeNameId = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("AttendeeNameId");
                OnAttendeeNameIdChanged();
            }
        }
        private global::System.String _AttendeeNameId;
        partial void OnAttendeeNameIdChanging(global::System.String value);
        partial void OnAttendeeNameIdChanged();

        #endregion

    
        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("NerdDinnerModel", "FK_RSVP_Dinners", "Dinners")]
        public Dinner Dinner
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Dinner>("NerdDinnerModel.FK_RSVP_Dinners", "Dinners").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Dinner>("NerdDinnerModel.FK_RSVP_Dinners", "Dinners").Value = value;
            }
        }
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Dinner> DinnerReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Dinner>("NerdDinnerModel.FK_RSVP_Dinners", "Dinners");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Dinner>("NerdDinnerModel.FK_RSVP_Dinners", "Dinners", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}
