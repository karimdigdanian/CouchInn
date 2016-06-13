﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace libCounchinn.Modelo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ModeloLibCouchin : DbContext
    {
        public ModeloLibCouchin()
            : base("name=ModeloLibCouchin")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DIRECCION> DIRECCIONs { get; set; }
        public virtual DbSet<PERSONA> PERSONAs { get; set; }
        public virtual DbSet<PUBLICACION> PUBLICACIONs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TABLA> TABLAClaves { get; set; }
        public virtual DbSet<TABLAS> TABLASDescripciones { get; set; }
        public virtual DbSet<TIPO_HOSPEDAJE> TIPO_HOSPEDAJE { get; set; }
        public virtual DbSet<USUARIO> USUARIOs { get; set; }
        public virtual DbSet<FOTO> FOTOS { get; set; }
        public virtual DbSet<CONTRIBUCIONE> CONTRIBUCIONES { get; set; }
        public virtual DbSet<COUCHINNS_REALIZADOS> COUCHINNS_REALIZADOS { get; set; }
        public virtual DbSet<RESERVA> RESERVAS { get; set; }
    
        public virtual ObjectResult<SEL_LOGIN_Result> SEL_LOGIN(string nOMBRE_USUARIO, string cONTRASEÑA)
        {
            var nOMBRE_USUARIOParameter = nOMBRE_USUARIO != null ?
                new ObjectParameter("NOMBRE_USUARIO", nOMBRE_USUARIO) :
                new ObjectParameter("NOMBRE_USUARIO", typeof(string));
    
            var cONTRASEÑAParameter = cONTRASEÑA != null ?
                new ObjectParameter("CONTRASEÑA", cONTRASEÑA) :
                new ObjectParameter("CONTRASEÑA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SEL_LOGIN_Result>("SEL_LOGIN", nOMBRE_USUARIOParameter, cONTRASEÑAParameter);
        }
    
        public virtual int INS_CONTRIBUCIONES_USUARIO(Nullable<int> iD_USUARIO, string mONTO, Nullable<System.DateTime> fECHA)
        {
            var iD_USUARIOParameter = iD_USUARIO.HasValue ?
                new ObjectParameter("ID_USUARIO", iD_USUARIO) :
                new ObjectParameter("ID_USUARIO", typeof(int));
    
            var mONTOParameter = mONTO != null ?
                new ObjectParameter("MONTO", mONTO) :
                new ObjectParameter("MONTO", typeof(string));
    
            var fECHAParameter = fECHA.HasValue ?
                new ObjectParameter("FECHA", fECHA) :
                new ObjectParameter("FECHA", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INS_CONTRIBUCIONES_USUARIO", iD_USUARIOParameter, mONTOParameter, fECHAParameter);
        }
    
        public virtual int INS_TIPOHOSPEDAJE(string dESCRIPCION)
        {
            var dESCRIPCIONParameter = dESCRIPCION != null ?
                new ObjectParameter("DESCRIPCION", dESCRIPCION) :
                new ObjectParameter("DESCRIPCION", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INS_TIPOHOSPEDAJE", dESCRIPCIONParameter);
        }
    
        public virtual ObjectResult<SEL_TIPOHOSPEDAJE_Result> SEL_TIPOHOSPEDAJE(Nullable<bool> pARAM)
        {
            var pARAMParameter = pARAM.HasValue ?
                new ObjectParameter("PARAM", pARAM) :
                new ObjectParameter("PARAM", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SEL_TIPOHOSPEDAJE_Result>("SEL_TIPOHOSPEDAJE", pARAMParameter);
        }
    
        public virtual int UPD_ACTUALIZAR_CONTRASENA(Nullable<int> iD_USUARIO, string cONTRASEÑA)
        {
            var iD_USUARIOParameter = iD_USUARIO.HasValue ?
                new ObjectParameter("ID_USUARIO", iD_USUARIO) :
                new ObjectParameter("ID_USUARIO", typeof(int));
    
            var cONTRASEÑAParameter = cONTRASEÑA != null ?
                new ObjectParameter("CONTRASEÑA", cONTRASEÑA) :
                new ObjectParameter("CONTRASEÑA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UPD_ACTUALIZAR_CONTRASENA", iD_USUARIOParameter, cONTRASEÑAParameter);
        }
    
        public virtual int UPD_TIPO_HOSPEDAJE(Nullable<int> iD_TIPO_HOSPEDAJE, string dESCRIPCION, Nullable<bool> eSTADO)
        {
            var iD_TIPO_HOSPEDAJEParameter = iD_TIPO_HOSPEDAJE.HasValue ?
                new ObjectParameter("ID_TIPO_HOSPEDAJE", iD_TIPO_HOSPEDAJE) :
                new ObjectParameter("ID_TIPO_HOSPEDAJE", typeof(int));
    
            var dESCRIPCIONParameter = dESCRIPCION != null ?
                new ObjectParameter("DESCRIPCION", dESCRIPCION) :
                new ObjectParameter("DESCRIPCION", typeof(string));
    
            var eSTADOParameter = eSTADO.HasValue ?
                new ObjectParameter("ESTADO", eSTADO) :
                new ObjectParameter("ESTADO", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UPD_TIPO_HOSPEDAJE", iD_TIPO_HOSPEDAJEParameter, dESCRIPCIONParameter, eSTADOParameter);
        }
    
        public virtual ObjectResult<SEL_IMAGENESPUBLICACION_Result> SEL_IMAGENESPUBLICACION()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SEL_IMAGENESPUBLICACION_Result>("SEL_IMAGENESPUBLICACION");
        }
    
        public virtual ObjectResult<SEL_VERDETALLESHOSPEDAJE_Result> SEL_VERDETALLESHOSPEDAJE(Nullable<int> iD_PUBLICACION)
        {
            var iD_PUBLICACIONParameter = iD_PUBLICACION.HasValue ?
                new ObjectParameter("ID_PUBLICACION", iD_PUBLICACION) :
                new ObjectParameter("ID_PUBLICACION", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SEL_VERDETALLESHOSPEDAJE_Result>("SEL_VERDETALLESHOSPEDAJE", iD_PUBLICACIONParameter);
        }
    
        public virtual int INS_IMAGEN_PUBLICACION(byte[] iMAGEN, Nullable<int> iD_PUB)
        {
            var iMAGENParameter = iMAGEN != null ?
                new ObjectParameter("IMAGEN", iMAGEN) :
                new ObjectParameter("IMAGEN", typeof(byte[]));
    
            var iD_PUBParameter = iD_PUB.HasValue ?
                new ObjectParameter("ID_PUB", iD_PUB) :
                new ObjectParameter("ID_PUB", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INS_IMAGEN_PUBLICACION", iMAGENParameter, iD_PUBParameter);
        }
    
        public virtual ObjectResult<SEL_ULTIMO_ID_PERSONA_Result> SEL_ULTIMO_ID_PERSONA()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SEL_ULTIMO_ID_PERSONA_Result>("SEL_ULTIMO_ID_PERSONA");
        }
    
        public virtual int INS_PERSONA(string nOMBRE, string aPELLIDO, string e_MAIL_LARGO, Nullable<int> uBICACION)
        {
            var nOMBREParameter = nOMBRE != null ?
                new ObjectParameter("NOMBRE", nOMBRE) :
                new ObjectParameter("NOMBRE", typeof(string));
    
            var aPELLIDOParameter = aPELLIDO != null ?
                new ObjectParameter("APELLIDO", aPELLIDO) :
                new ObjectParameter("APELLIDO", typeof(string));
    
            var e_MAIL_LARGOParameter = e_MAIL_LARGO != null ?
                new ObjectParameter("E_MAIL_LARGO", e_MAIL_LARGO) :
                new ObjectParameter("E_MAIL_LARGO", typeof(string));
    
            var uBICACIONParameter = uBICACION.HasValue ?
                new ObjectParameter("UBICACION", uBICACION) :
                new ObjectParameter("UBICACION", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INS_PERSONA", nOMBREParameter, aPELLIDOParameter, e_MAIL_LARGOParameter, uBICACIONParameter);
        }
    
        public virtual int INS_USUARIO(Nullable<int> iD_PERSONA, string nOMRE_USUARIO, string cONTRASEÑA, Nullable<int> tIPO_USUARIO)
        {
            var iD_PERSONAParameter = iD_PERSONA.HasValue ?
                new ObjectParameter("ID_PERSONA", iD_PERSONA) :
                new ObjectParameter("ID_PERSONA", typeof(int));
    
            var nOMRE_USUARIOParameter = nOMRE_USUARIO != null ?
                new ObjectParameter("NOMRE_USUARIO", nOMRE_USUARIO) :
                new ObjectParameter("NOMRE_USUARIO", typeof(string));
    
            var cONTRASEÑAParameter = cONTRASEÑA != null ?
                new ObjectParameter("CONTRASEÑA", cONTRASEÑA) :
                new ObjectParameter("CONTRASEÑA", typeof(string));
    
            var tIPO_USUARIOParameter = tIPO_USUARIO.HasValue ?
                new ObjectParameter("TIPO_USUARIO", tIPO_USUARIO) :
                new ObjectParameter("TIPO_USUARIO", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INS_USUARIO", iD_PERSONAParameter, nOMRE_USUARIOParameter, cONTRASEÑAParameter, tIPO_USUARIOParameter);
        }
    
        public virtual int INS_DIRECCION(string pAIS, string pROVINCIA, string cUIDAD, string aLTURA, string cALLE, string pISO, string dEPARTAMENTO)
        {
            var pAISParameter = pAIS != null ?
                new ObjectParameter("PAIS", pAIS) :
                new ObjectParameter("PAIS", typeof(string));
    
            var pROVINCIAParameter = pROVINCIA != null ?
                new ObjectParameter("PROVINCIA", pROVINCIA) :
                new ObjectParameter("PROVINCIA", typeof(string));
    
            var cUIDADParameter = cUIDAD != null ?
                new ObjectParameter("CUIDAD", cUIDAD) :
                new ObjectParameter("CUIDAD", typeof(string));
    
            var aLTURAParameter = aLTURA != null ?
                new ObjectParameter("ALTURA", aLTURA) :
                new ObjectParameter("ALTURA", typeof(string));
    
            var cALLEParameter = cALLE != null ?
                new ObjectParameter("CALLE", cALLE) :
                new ObjectParameter("CALLE", typeof(string));
    
            var pISOParameter = pISO != null ?
                new ObjectParameter("PISO", pISO) :
                new ObjectParameter("PISO", typeof(string));
    
            var dEPARTAMENTOParameter = dEPARTAMENTO != null ?
                new ObjectParameter("DEPARTAMENTO", dEPARTAMENTO) :
                new ObjectParameter("DEPARTAMENTO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INS_DIRECCION", pAISParameter, pROVINCIAParameter, cUIDADParameter, aLTURAParameter, cALLEParameter, pISOParameter, dEPARTAMENTOParameter);
        }
    
        public virtual int UPD_DIRECCION(Nullable<int> iD_DIRECION, string pAIS, string pROVINCIA, string cUIDAD, string cALLE, string aLTURA, string pISO, string dEPARTAMENTO)
        {
            var iD_DIRECIONParameter = iD_DIRECION.HasValue ?
                new ObjectParameter("ID_DIRECION", iD_DIRECION) :
                new ObjectParameter("ID_DIRECION", typeof(int));
    
            var pAISParameter = pAIS != null ?
                new ObjectParameter("PAIS", pAIS) :
                new ObjectParameter("PAIS", typeof(string));
    
            var pROVINCIAParameter = pROVINCIA != null ?
                new ObjectParameter("PROVINCIA", pROVINCIA) :
                new ObjectParameter("PROVINCIA", typeof(string));
    
            var cUIDADParameter = cUIDAD != null ?
                new ObjectParameter("CUIDAD", cUIDAD) :
                new ObjectParameter("CUIDAD", typeof(string));
    
            var cALLEParameter = cALLE != null ?
                new ObjectParameter("CALLE", cALLE) :
                new ObjectParameter("CALLE", typeof(string));
    
            var aLTURAParameter = aLTURA != null ?
                new ObjectParameter("ALTURA", aLTURA) :
                new ObjectParameter("ALTURA", typeof(string));
    
            var pISOParameter = pISO != null ?
                new ObjectParameter("PISO", pISO) :
                new ObjectParameter("PISO", typeof(string));
    
            var dEPARTAMENTOParameter = dEPARTAMENTO != null ?
                new ObjectParameter("DEPARTAMENTO", dEPARTAMENTO) :
                new ObjectParameter("DEPARTAMENTO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UPD_DIRECCION", iD_DIRECIONParameter, pAISParameter, pROVINCIAParameter, cUIDADParameter, cALLEParameter, aLTURAParameter, pISOParameter, dEPARTAMENTOParameter);
        }
    
        public virtual int UPD_PERSONA(Nullable<int> iD_PERSONA, string nOMRE, string aPELLIDO, string eMAIL_LARGO)
        {
            var iD_PERSONAParameter = iD_PERSONA.HasValue ?
                new ObjectParameter("ID_PERSONA", iD_PERSONA) :
                new ObjectParameter("ID_PERSONA", typeof(int));
    
            var nOMREParameter = nOMRE != null ?
                new ObjectParameter("NOMRE", nOMRE) :
                new ObjectParameter("NOMRE", typeof(string));
    
            var aPELLIDOParameter = aPELLIDO != null ?
                new ObjectParameter("APELLIDO", aPELLIDO) :
                new ObjectParameter("APELLIDO", typeof(string));
    
            var eMAIL_LARGOParameter = eMAIL_LARGO != null ?
                new ObjectParameter("EMAIL_LARGO", eMAIL_LARGO) :
                new ObjectParameter("EMAIL_LARGO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UPD_PERSONA", iD_PERSONAParameter, nOMREParameter, aPELLIDOParameter, eMAIL_LARGOParameter);
        }
    
        public virtual ObjectResult<SEL_ULTIMO_IDDIRECION_Result> SEL_ULTIMO_IDDIRECION()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SEL_ULTIMO_IDDIRECION_Result>("SEL_ULTIMO_IDDIRECION");
        }
    
        public virtual int INS_PUBLICACION(Nullable<int> iD_USUARIO, Nullable<int> iD_DIRECCION, Nullable<System.DateTime> fECHA_INICIO, Nullable<System.DateTime> fECHA_FIN, Nullable<int> tIPO_HOSPEDAJE, Nullable<int> cANT_PERSONAS, byte[] fOTO_PRINCIPAL, string tITULO_PUBLICACION, string dESCRIPCION_PUBLICACION)
        {
            var iD_USUARIOParameter = iD_USUARIO.HasValue ?
                new ObjectParameter("ID_USUARIO", iD_USUARIO) :
                new ObjectParameter("ID_USUARIO", typeof(int));
    
            var iD_DIRECCIONParameter = iD_DIRECCION.HasValue ?
                new ObjectParameter("ID_DIRECCION", iD_DIRECCION) :
                new ObjectParameter("ID_DIRECCION", typeof(int));
    
            var fECHA_INICIOParameter = fECHA_INICIO.HasValue ?
                new ObjectParameter("FECHA_INICIO", fECHA_INICIO) :
                new ObjectParameter("FECHA_INICIO", typeof(System.DateTime));
    
            var fECHA_FINParameter = fECHA_FIN.HasValue ?
                new ObjectParameter("FECHA_FIN", fECHA_FIN) :
                new ObjectParameter("FECHA_FIN", typeof(System.DateTime));
    
            var tIPO_HOSPEDAJEParameter = tIPO_HOSPEDAJE.HasValue ?
                new ObjectParameter("TIPO_HOSPEDAJE", tIPO_HOSPEDAJE) :
                new ObjectParameter("TIPO_HOSPEDAJE", typeof(int));
    
            var cANT_PERSONASParameter = cANT_PERSONAS.HasValue ?
                new ObjectParameter("CANT_PERSONAS", cANT_PERSONAS) :
                new ObjectParameter("CANT_PERSONAS", typeof(int));
    
            var fOTO_PRINCIPALParameter = fOTO_PRINCIPAL != null ?
                new ObjectParameter("FOTO_PRINCIPAL", fOTO_PRINCIPAL) :
                new ObjectParameter("FOTO_PRINCIPAL", typeof(byte[]));
    
            var tITULO_PUBLICACIONParameter = tITULO_PUBLICACION != null ?
                new ObjectParameter("TITULO_PUBLICACION", tITULO_PUBLICACION) :
                new ObjectParameter("TITULO_PUBLICACION", typeof(string));
    
            var dESCRIPCION_PUBLICACIONParameter = dESCRIPCION_PUBLICACION != null ?
                new ObjectParameter("DESCRIPCION_PUBLICACION", dESCRIPCION_PUBLICACION) :
                new ObjectParameter("DESCRIPCION_PUBLICACION", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INS_PUBLICACION", iD_USUARIOParameter, iD_DIRECCIONParameter, fECHA_INICIOParameter, fECHA_FINParameter, tIPO_HOSPEDAJEParameter, cANT_PERSONASParameter, fOTO_PRINCIPALParameter, tITULO_PUBLICACIONParameter, dESCRIPCION_PUBLICACIONParameter);
        }
    }
}
