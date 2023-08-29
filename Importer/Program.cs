// See https://aka.ms/new-console-template for more information
using ClosedXML.Excel;
using Importer;

//Importar();

var _context = new DataContext();
var list = _context.PecasImportar.ToList();
int ini = 10004;
foreach (var pecas in list)
{
    pecas.mic = ini.ToString();
    ini++;
}
_context.SaveChanges();


static void Importar()
{
    var _context = new DataContext();
    var xls = new XLWorkbook(@"importar.xlsx");
    var planilha = xls.Worksheets.First(w => w.Name == "Planilha1");
    var totalLinhas = planilha.Rows().Count();
    // primeira linha é o cabecalho
    for (int l = 2; l <= totalLinhas; l++)
    {
        var pecasModel = new PecaModel();

        pecasModel.ID = int.Parse(planilha.Cell($"A{l}").Value.ToString());
        pecasModel.codigo = planilha.Cell($"B{l}").Value.ToString();
        pecasModel.descricao = planilha.Cell($"C{l}").Value.ToString();
        pecasModel.preco_bruto = double.Parse(planilha.Cell($"D{l}").Value.ToString());
        pecasModel.qtd = int.Parse(planilha.Cell($"E{l}").Value.ToString());
        pecasModel.barras = planilha.Cell($"F{l}").Value.ToString();
        pecasModel.peso_liq = double.Parse(planilha.Cell($"G{l}").Value.ToString());
        pecasModel.unidade = planilha.Cell($"H{l}").Value.ToString();
        pecasModel.ncm = planilha.Cell($"I{l}").Value.ToString();
        pecasModel.desconto = double.Parse(planilha.Cell($"J{l}").Value.ToString());

        try
        {
            _context.PecasImportar.Add(pecasModel);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }


    }
}
