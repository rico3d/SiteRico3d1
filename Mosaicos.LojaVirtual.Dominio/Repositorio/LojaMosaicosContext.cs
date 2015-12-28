﻿ 

// -----------------------------------------------------------------------
// <autogenerated>
//    This code was generated from a template.
//
//    Changes to this file may cause incorrect behaviour and will be lost
//    if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using BrightstarDB.Client;
using BrightstarDB.EntityFramework;

using System.Text;
using System.Threading.Tasks;

namespace Mosaicos.LojaVirtual.Dominio.Repositorio 
{
    public partial class LojaMosaicosContext : BrightstarEntityContext {
    	
    	static LojaMosaicosContext() 
    	{
            InitializeEntityMappingStore();
        }
        
        /// <summary>
        /// Initialize the internal cache of entity attribute information.
        /// </summary>
        /// <remarks>
        /// This method is normally invoked from the static constructor for the generated context class.
        /// It is provided as a public static method to enable the use of the cached entity attribute 
        /// information without the need to construct a context (typically in test code). 
        /// In normal application code you should never need to explicitly call this method.
        /// </remarks>
        public static void InitializeEntityMappingStore()
        {
    		var provider = new ReflectionMappingProvider();
    		provider.AddMappingsForType(EntityMappingStore.Instance, typeof(Mosaicos.LojaVirtual.Dominio.Repositorio.IMosaico));
    		EntityMappingStore.Instance.SetImplMapping<Mosaicos.LojaVirtual.Dominio.Repositorio.IMosaico, Mosaicos.LojaVirtual.Dominio.Repositorio.Mosaico>();
    	}
    	
    	/// <summary>
    	/// Initialize a new entity context using the specified BrightstarDB
    	/// Data Object Store connection
    	/// </summary>
    	/// <param name="dataObjectStore">The connection to the BrightstarDB Data Object Store that will provide the entity objects</param>
    	public LojaMosaicosContext(IDataObjectStore dataObjectStore) : base(dataObjectStore)
    	{
    		InitializeContext();
    	}
    
    	/// <summary>
    	/// Initialize a new entity context using the specified Brightstar connection string
    	/// </summary>
    	/// <param name="connectionString">The connection to be used to connect to an existing BrightstarDB store</param>
    	/// <param name="enableOptimisticLocking">OPTIONAL: If set to true optmistic locking will be applied to all entity updates</param>
        /// <param name="updateGraphUri">OPTIONAL: The URI identifier of the graph to be updated with any new triples created by operations on the store. If
        /// not defined, the default graph in the store will be updated.</param>
        /// <param name="datasetGraphUris">OPTIONAL: The URI identifiers of the graphs that will be queried to retrieve entities and their properties.
        /// If not defined, all graphs in the store will be queried.</param>
        /// <param name="versionGraphUri">OPTIONAL: The URI identifier of the graph that contains version number statements for entities. 
        /// If not defined, the <paramref name="updateGraphUri"/> will be used.</param>
    	public LojaMosaicosContext(
    	    string connectionString, 
    		bool? enableOptimisticLocking=null,
    		string updateGraphUri = null,
    		IEnumerable<string> datasetGraphUris = null,
    		string versionGraphUri = null
        ) : base(connectionString, enableOptimisticLocking, updateGraphUri, datasetGraphUris, versionGraphUri)
    	{
    		InitializeContext();
    	}
    
    	/// <summary>
    	/// Initialize a new entity context using the specified Brightstar
    	/// connection string retrieved from the configuration.
    	/// </summary>
    	public LojaMosaicosContext() : base()
    	{
    		InitializeContext();
    	}
    	
    	/// <summary>
    	/// Initialize a new entity context using the specified Brightstar
    	/// connection string retrieved from the configuration and the
    	//  specified target graphs
    	/// </summary>
        /// <param name="updateGraphUri">The URI identifier of the graph to be updated with any new triples created by operations on the store. If
        /// set to null, the default graph in the store will be updated.</param>
        /// <param name="datasetGraphUris">The URI identifiers of the graphs that will be queried to retrieve entities and their properties.
        /// If set to null, all graphs in the store will be queried.</param>
        /// <param name="versionGraphUri">The URI identifier of the graph that contains version number statements for entities. 
        /// If set to null, the value of <paramref name="updateGraphUri"/> will be used.</param>
    	public LojaMosaicosContext(
    		string updateGraphUri,
    		IEnumerable<string> datasetGraphUris,
    		string versionGraphUri
    	) : base(updateGraphUri:updateGraphUri, datasetGraphUris:datasetGraphUris, versionGraphUri:versionGraphUri)
    	{
    		InitializeContext();
    	}
    	
    	private void InitializeContext() 
    	{
    		Mosaicos = 	new BrightstarEntitySet<Mosaicos.LojaVirtual.Dominio.Repositorio.IMosaico>(this);
    	}
    	
    	public IEntitySet<Mosaicos.LojaVirtual.Dominio.Repositorio.IMosaico> Mosaicos
    	{
    		get; private set;
    	}
    	
        public IEntitySet<T> EntitySet<T>() where T : class {
            var itemType = typeof(T);
            if (typeof(T).Equals(typeof(Mosaicos.LojaVirtual.Dominio.Repositorio.IMosaico))) {
                return (IEntitySet<T>)this.Mosaicos;
            }
            throw new InvalidOperationException(typeof(T).FullName + " is not a recognized entity interface type.");
        }
    
        } // end class LojaMosaicosContext
        
}
namespace Mosaicos.LojaVirtual.Dominio.Repositorio 
{
    
    public partial class Mosaico : BrightstarEntityObject, IMosaico 
    {
    	public Mosaico(BrightstarEntityContext context, BrightstarDB.Client.IDataObject dataObject) : base(context, dataObject) { }
        public Mosaico(BrightstarEntityContext context) : base(context, typeof(Mosaico)) { }
    	public Mosaico() : base() { }
    	public System.String Id { get {return GetKey(); } set { SetKey(value); } }
    	#region Implementation of Mosaicos.LojaVirtual.Dominio.Repositorio.IMosaico
    
    	public System.Int32 Item
    	{
            		get { return GetRelatedProperty<System.Int32>("Item"); }
            		set { SetRelatedProperty("Item", value); }
    	}
    
    	public System.String Nome
    	{
            		get { return GetRelatedProperty<System.String>("Nome"); }
            		set { SetRelatedProperty("Nome", value); }
    	}
    
    	public System.String Descricao
    	{
            		get { return GetRelatedProperty<System.String>("Descricao"); }
            		set { SetRelatedProperty("Descricao", value); }
    	}
    
    	public System.Decimal Preco
    	{
            		get { return GetRelatedProperty<System.Decimal>("Preco"); }
            		set { SetRelatedProperty("Preco", value); }
    	}
    
    	public System.Decimal Peso
    	{
            		get { return GetRelatedProperty<System.Decimal>("Peso"); }
            		set { SetRelatedProperty("Peso", value); }
    	}
    
    	public System.String Dimensao
    	{
            		get { return GetRelatedProperty<System.String>("Dimensao"); }
            		set { SetRelatedProperty("Dimensao", value); }
    	}
    
    	public System.String Imagem
    	{
            		get { return GetRelatedProperty<System.String>("Imagem"); }
            		set { SetRelatedProperty("Imagem", value); }
    	}
    	#endregion
    }
}
