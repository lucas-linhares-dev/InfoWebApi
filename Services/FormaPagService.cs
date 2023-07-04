using InfoWeb.Models;
namespace InfoWeb.Services;


public static class FormaPagService
{
    static List<FormaPag> FormasPag { get; }
    static int nextId = 3;


    public static List<FormaPag> GetAll() => FormasPag;

    public static FormaPag? Get(int id) => FormasPag.FirstOrDefault(p => p.fpg_codigo == id);

    public static void Add(FormaPag FormaPag)
    {
        FormaPag.fpg_codigo = nextId++;
        FormasPag.Add(FormaPag);
    }

    public static void Delete(int id)
    {
        var FormaPag = Get(id);
        if (FormaPag is null)
            return;

        FormasPag.Remove(FormaPag);
    }

    public static void Update(FormaPag FormaPag)
    {
        var index = FormasPag.FindIndex(p => p.fpg_codigo == FormaPag.fpg_codigo);
        if (index == -1)
            return;

        FormasPag[index] = FormaPag;

    }
}