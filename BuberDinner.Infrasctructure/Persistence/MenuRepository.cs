using BuberDinner.Application.Common.Interfaces.Persistence;
using BuberDinner.Domain.MenuAggregate;

namespace BuberDinner.Infrasctructure.Persistence
{
    public class MenuRepository : IMenuRepository
    {
        private readonly static List<Menu> _menu = new();
        public void Add(Menu menu)
        {
            _menu.Add(menu);
        }
    }
}
