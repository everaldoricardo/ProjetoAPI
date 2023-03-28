namespace APICatalogo.Repositories
{
    public class CatalogoRepositorycs
    {
        public interface IcatalogoRepository
        {
            List<Catalogo> Read();
            
            void Create(Catalogo catalogo);

            void Delete(Guid Id);

            void Update(Catalogo catalogo);
        }

        public class CatalogRepository : IcatalogoRepository
        {
            public void Create(Catalogo catalogo)
            {
                throw new NotImplementedException();
            }

            public void Delete(Guid Id)
            {
                throw new NotImplementedException();
            }

            public List<Catalogo> Read()
            {
                throw new NotImplementedException();
            }

            public void Update(Catalogo catalogo)
            {
                throw new NotImplementedException();
            }
        }
    }
}
