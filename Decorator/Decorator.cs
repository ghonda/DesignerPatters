namespace Decorator
{
    public class Decorator : ItemBiblioteca
    {
        protected ItemBiblioteca _itemBiblioteca;
        public Decorator(ItemBiblioteca itemBiblioteca)
        {
            _itemBiblioteca = itemBiblioteca;
        }
        public override void Exibe()
        {
            _itemBiblioteca.Exibe();
        }
    }
}
