using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing.Imaging;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace over.Relatorios
{
    internal class CriarRelatorios
    {

        Conexao conexao = new Conexao();
        

        public void gerarRelatorioIndividuais (string Tabela, Dictionary<string, string> atributos)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Salvar relatório como";
            saveFileDialog.FileName = $"Relatorio {atributos["Nome"]}.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //INCIALIZACAO --------------------------------
                FileStream arquivoPDF = new FileStream(saveFileDialog.FileName, FileMode.Create);
                Document doc = new Document(PageSize.A4);
                PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);
                string dados = "";

                //INSERÇÃO DA IMAGEM --------------------------------
                iTextSharp.text.Image logo;

                using (MemoryStream ms = new MemoryStream())
                {
                    Properties.Resources.logo.Save(ms, ImageFormat.Png); // Converte a imagem para PNG em um MemoryStream
                    logo = iTextSharp.text.Image.GetInstance(ms.ToArray());
                    logo.ScaleToFit(40f, 40f); // Ajusta o tamanho da imagem (ajuste conforme necessário)
                    logo.SetAbsolutePosition(20, doc.PageSize.Height - 50); // Define a posição (ajuste conforme necessário)
                }

                //TITULO --------------------------------
                Paragraph paragrafo1 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 28, (int)System.Drawing.FontStyle.Bold));
                paragrafo1.Alignment = Element.ALIGN_CENTER;
                paragrafo1.Add($"{atributos["Nome"].ToUpper()}\n\n");

                Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 22));
                paragrafo2.Alignment = Element.ALIGN_LEFT;

                foreach (var atributo in atributos)
                {
                    if (atributo.Key == "Nome") continue;
                    paragrafo2.Add($"{atributo.Key}: {atributo.Value}\n\n");
                }

                //MENSAGEM FINAL----------------------------------
                Paragraph mensagemFinal = new Paragraph($"\nRelatório de {atributos["Nome"].ToUpper()} emitido dia {DateTime.Now:dd/MM/yyyy} às {DateTime.Now:HH:mm}.", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10, (int)System.Drawing.FontStyle.Italic));
                mensagemFinal.Alignment = Element.ALIGN_CENTER;

                //FINALIZACAO--------------------------------
                doc.Open();
                doc.Add(logo);
                doc.Add(paragrafo1);
                doc.Add(paragrafo2);
                doc.Add(mensagemFinal);
                doc.Close();

                //CONFIRMACAO DE VISUALIZACAO--------------------------------
                DialogResult res = MessageBox.Show("Deseja abrir o relatório?", "Relatório", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes) { System.Diagnostics.Process.Start(saveFileDialog.FileName); }
            }

        }

        public void gerarRelatorioGeral(string Tabela)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Salvar relatório como";
            saveFileDialog.FileName = $"{Tabela}.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //INCIALIZACAO --------------------------------
                FileStream arquivoPDF = new FileStream(saveFileDialog.FileName, FileMode.Create);
                Document doc = new Document(PageSize.A4.Rotate());
                PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);
                DataTable dt = conexao.CarregarDados(Tabela);
                string dados = "";

                //INSERÇÃO DA IMAGEM --------------------------------
                iTextSharp.text.Image logo;

                using (MemoryStream ms = new MemoryStream())
                {
                    Properties.Resources.logo.Save(ms, ImageFormat.Png); // Converte a imagem para PNG em um MemoryStream
                    logo = iTextSharp.text.Image.GetInstance(ms.ToArray());
                    logo.ScaleToFit(40f, 40f); // Ajusta o tamanho da imagem (ajuste conforme necessário)
                    logo.SetAbsolutePosition(20, doc.PageSize.Height - 50); // Define a posição (ajuste conforme necessário)
                }

                //TITULO --------------------------------
                Paragraph paragrafo1 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));
                paragrafo1.Alignment = Element.ALIGN_CENTER;
                paragrafo1.Add($"{Tabela.ToUpper()}\n\n");

                //CRIACAO DA TABELA --------------------------------
                PdfPTable tabelapdf = new PdfPTable(conexao.Coluna.Count);
                tabelapdf.DefaultCell.FixedHeight = 20;

                //FORMATACAO NEGRITO --------------------------------
                iTextSharp.text.Font fonteNegrito = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD);

                //TITULO TABELA--------------------------
                PdfPCell celulaPrincipal = new PdfPCell(new Phrase($"Relatório de {Tabela}", fonteNegrito));
                celulaPrincipal.Colspan = conexao.Coluna.Count;
                celulaPrincipal.HorizontalAlignment = Element.ALIGN_CENTER;
                celulaPrincipal.VerticalAlignment = Element.ALIGN_CENTER;
                celulaPrincipal.BackgroundColor = new iTextSharp.text.BaseColor(215, 217, 219);
                tabelapdf.AddCell(celulaPrincipal);

                //COLUNAS--------------------------------
                for (int i = 0; i < conexao.Coluna.Count; i++)
                {
                    PdfPCell celulaColunas = new PdfPCell(new Phrase(conexao.Coluna[i], fonteNegrito));
                    celulaColunas.HorizontalAlignment = Element.ALIGN_CENTER;
                    celulaColunas.BackgroundColor = new iTextSharp.text.BaseColor(235, 236, 237);
                    tabelapdf.AddCell(celulaColunas);
                }

                //DADOS----------------------------------
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < conexao.Coluna.Count; j++)
                    {
                        object valorCelula = dt.Rows[i].Field<object>(conexao.Coluna[j]);
                        string textoCelula;

                        if (valorCelula is DateTime)
                        {
                            textoCelula = ((DateTime)valorCelula).ToString("dd/MM/yyyy");
                        }
                        else
                        {
                            textoCelula = valorCelula.ToString();
                        }

                        PdfPCell celulaDados = new PdfPCell(new Phrase(textoCelula));
                        celulaDados.HorizontalAlignment = Element.ALIGN_CENTER;
                        tabelapdf.AddCell(celulaDados);
                    }
                }

                //MENSAGEM FINAL----------------------------------
                Paragraph mensagemFinal = new Paragraph($"\nRelatório de {Tabela} emitido dia {DateTime.Now:dd/MM/yyyy} às {DateTime.Now:HH:mm}.", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10, (int)System.Drawing.FontStyle.Italic));
                mensagemFinal.Alignment = Element.ALIGN_CENTER;

                //FINALIZACAO--------------------------------
                doc.Open();
                doc.Add(logo);
                doc.Add(paragrafo1);
                doc.Add(tabelapdf);
                doc.Add(mensagemFinal);
                doc.Close();

                //CONFIRMACAO DE VISUALIZACAO--------------------------------
                DialogResult res = MessageBox.Show("Deseja abrir o relatório?", "Relatório", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes) { System.Diagnostics.Process.Start(saveFileDialog.FileName); }

            }
        }
    }
}
