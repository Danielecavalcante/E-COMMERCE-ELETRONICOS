﻿namespace ApplicationApp.OpenApp
{
    public class AppMontaMenu : InterfaceMontaMenu
    {
        private readonly IServiceMontaMenu _IServiceMontaMenu;
        public AppMontaMenu(IServiceMontaMenu IServiceMontaMenu)
        {
            _IServiceMontaMenu = IServiceMontaMenu;
        }

        public async Task<List<MenuSite>> MontaMenuPorPerfil(string userID)
        {
            return await _IServiceMontaMenu.MontaMenuPorPerfil(userID);
        }
    }
}

