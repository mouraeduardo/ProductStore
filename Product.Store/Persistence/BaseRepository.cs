namespace ProductStore.Persistence
{
    public abstract class BaseRepository
    {
        protected AppDBContext _context;
        public BaseRepository(AppDBContext context) 
        {
            _context = context;
        }
    }
}
