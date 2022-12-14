
using SQLite;
using SQLiteNetExtensionsAsync.Extensions;
using ENCHERE_SIO.Modeles;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ENCHERE_SIO.Services
{
    public class GestionDatabase
    {
        #region Attributs
        static SQLiteAsyncConnection Database => lazyInitializer.Value;
        static bool initialized = false;
        #endregion
        #region Constructeurs
        public GestionDatabase()
        {
            InitializeAsync().SafeFireAndForget(false);
        }
        #endregion
        #region Methodes
        static readonly Lazy<SQLiteAsyncConnection> lazyInitializer = new Lazy<SQLiteAsyncConnection>(() =>
        {
            return new SQLiteAsyncConnection(Constantes.DatabasePath, Constantes.Flags);
        });
        async Task InitializeAsync()
        {
            if (!initialized)
            {

                if (!Database.TableMappings.Any(m => m.MappedType.Name == typeof(Article).Name))
                {

                    await Database.CreateTablesAsync(CreateFlags.None, typeof(Article)).ConfigureAwait(false);

                }
                if (!Database.TableMappings.Any(m => m.MappedType.Name == typeof(CaseSurprise).Name))
                {

                    await Database.CreateTablesAsync(CreateFlags.None, typeof(CaseSurprise)).ConfigureAwait(false);

                }
                if (!Database.TableMappings.Any(m => m.MappedType.Name == typeof(Enchere).Name))
                {

                    await Database.CreateTablesAsync(CreateFlags.None, typeof(Enchere)).ConfigureAwait(false);

                }
                if (!Database.TableMappings.Any(m => m.MappedType.Name == typeof(Enchere).Name))
                {

                    await Database.CreateTablesAsync(CreateFlags.None, typeof(Enchere)).ConfigureAwait(false);

                }
       
                if (!Database.TableMappings.Any(m => m.MappedType.Name == typeof(Magasin).Name))
                {

                    await Database.CreateTablesAsync(CreateFlags.None, typeof(Magasin)).ConfigureAwait(false);

                }
                if (!Database.TableMappings.Any(m => m.MappedType.Name == typeof(Participer).Name))
                {

                    await Database.CreateTablesAsync(CreateFlags.None, typeof(Participer)).ConfigureAwait(false);

                }
                if (!Database.TableMappings.Any(m => m.MappedType.Name == typeof(User).Name))
                {

                    await Database.CreateTablesAsync(CreateFlags.None, typeof(User)).ConfigureAwait(false);

                }




            }
            initialized = true;
        }
        public Task<int> SaveItemAsync<T>(T item)
        {

            PropertyInfo x = (item.GetType().GetProperty("Id"));
            int nbi = Convert.ToInt32(x.GetValue(item));
            if (nbi != 0)
            {
                return Database.UpdateAsync(item);
            }
            else
            {
                return Database.InsertAsync(item);
            }
        }
        public Task MiseAJourItemRelation(object item)
        {
            return Database.UpdateWithChildrenAsync(item);
        }
        public Task<int> DeleteItemsAsync<T>()
        {
            return Database.DeleteAllAsync<T>();
        }
        public ObservableCollection<T> GetItemsAsync<T>() where T : new()
        {
            ObservableCollection<T> resultat = new ObservableCollection<T>();
            List<T> liste = Database.Table<T>().ToListAsync().Result;
            foreach (T unObjet in liste)
            {
                resultat.Add(unObjet);
            }
            return resultat;
        }
        public Task<T> GetItemAvecRelations<T>(T item) where T : new()
        {
            PropertyInfo x = (item.GetType().GetProperty("Id"));
            int nbi = Convert.ToInt32(x.GetValue(item));
            return Database.GetWithChildrenAsync<T>(nbi);
        }
        public Task<T> GetItemAsync<T>(int id) where T : new()
        {
            return Database.FindAsync<T>(id); ;
        }
        #endregion
    }
}
