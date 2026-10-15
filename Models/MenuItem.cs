namespace PortalTransparencia.Models;

public class MenuItem
{
    public string Titulo { get; set; } = "";
    public string Url { get; set; } = "";
    public List<SubMenuItem> SubMenus { get; set; } = [];
}
