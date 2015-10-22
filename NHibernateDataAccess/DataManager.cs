using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Internal references
using DataModel;


namespace NHibernateDataAccess
{
    public class DataManager
    {
#region Static
        
        private static DataManager _dataManager = null;

        /// <summary>
        /// Give access to the unique allowed instance of this class
        /// </summary>
        /// <returns>The singleton instance</returns>
        public static DataManager getInstance()
        {
            if( null == _dataManager )
                _dataManager = new DataManager();

            return _dataManager;
        }
        
#endregion
#region Instance, Private

        // NHibernate Configuration  
        NHibernate.Cfg.Configuration config;

        // NHibernate Factory  
        private NHibernate.ISessionFactory sessionFactory;

        /// <summary>
        /// Private constructor that initialises the unique instance of this class
        /// </summary>
        private DataManager()
        {
            try
            {
                // Initialise NHibernate Configuration  
                this.config = new NHibernate.Cfg.Configuration().Configure();

                // Add assembly
                this.config.AddAssembly( typeof(Person).Assembly );
                //this.config.AddAssembly( "Contact.hbm.xml" );
                //this.config.AddAssembly( "Person.hbm.xml" );
                //this.config.AddAssembly( "Project.hbm.xml" );
                //this.config.AddAssembly( "DataModel" );

                // Initialise NHibernate factory
                sessionFactory = this.config.BuildSessionFactory();
            }
            catch( Exception ex )
            {
                throw ex;
            }
        }

        /// <summary>
        /// The Destructor closes the session if the session is still open
        /// </summary>
        ~DataManager()
        {
            // Close Factory
            if( this.sessionFactory != null && ! this.sessionFactory.IsClosed )
                sessionFactory.Close();
        }
        
#endregion
#region Instance, Public, Get Data

        /// <summary>
        /// Get the list of all person objects from the database
        /// </summary>
        /// <returns>The list of all person objects from the database</returns>
        public IList<Person> getAllPersons()
        {
            IList<Person> personList = null;

            try
            {
                // Open session
                NHibernate.ISession session = this.sessionFactory.OpenSession();

                // Start Transaction
                NHibernate.ITransaction transaction = session.BeginTransaction();

                // Read table 'Persons'
                personList = session.CreateCriteria<Person>().List<Person>();

                // Tell NHibernate that this object should be saved
                //session.Save(contact);

                transaction.Commit();
                session.Close();
            }
            catch( Exception ex )
            {
                throw ex;
            }

            return personList;
        }

        /// <summary>
        /// Get the list of all project objects from the database
        /// </summary>
        /// <returns>The list of all project objects from the database</returns>
        public IList<Project> getAllProjects()
        {
            IList<Project> projectList =null;

            try
            {
                // Open session
                NHibernate.ISession session = this.sessionFactory.OpenSession();

                // Start Transaction
                NHibernate.ITransaction transaction = session.BeginTransaction();

                // Read table 'Projects'
                projectList = session.CreateCriteria<Project>().List<Project>();

                // Tell NHibernate that this object should be saved
                //session.Save(contact);

                transaction.Commit();
                session.Close();
            }
            catch( Exception ex )
            {
                throw ex;
            }

            return projectList;
        }

#endregion
#region Instance, Public, Set Data

        /// <summary>
        /// Persist a person into the database
        /// </summary>
        /// <param name="person">The person that will be persisted in DB</param>
        public void savePerson( Person person )
        {
            try
            {
                // Open session
                NHibernate.ISession session = this.sessionFactory.OpenSession();

                // Start Transaction
                NHibernate.ITransaction transaction = session.BeginTransaction();

                // Tell NHibernate that this object should be saved
                session.Save( person );

                // Commit transaction
                transaction.Commit();

                // Close session
                session.Close();
            }
            catch( Exception ex )
            {
                throw ex;
            }
        }

        /// <summary>
        /// Persist a project into the database
        /// </summary>
        /// <param name="project">The project that will be persisted in DB</param>
        public void saveProject(Project projet)
        {
            try
            {
                // Open session
                NHibernate.ISession session = this.sessionFactory.OpenSession();

                // Start Transaction
                NHibernate.ITransaction transaction = session.BeginTransaction();

                // Tell NHibernate that this object should be saved
                session.Save( projet );

                // Commit transaction
                transaction.Commit();

                // Close session
                session.Close();
            }
            catch( Exception ex )
            {
                throw ex;
            }
        }
    }

#endregion
}
