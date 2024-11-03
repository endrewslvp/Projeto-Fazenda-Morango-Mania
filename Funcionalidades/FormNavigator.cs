using System.Collections.Generic;
using System.Windows.Forms;

public static class FormNavigator
{
    // Pilha para armazenar os formulários
    private static Stack<Form> formStack = new Stack<Form>();

    // Método para adicionar o formulário atual à pilha e abrir um novo formulário
    public static void OpenForm(Form currentForm, Form newForm)
    {
        formStack.Push(currentForm); // Adiciona o formulário atual à pilha
        newForm.Show();              // Mostra o novo formulário
        currentForm.Hide();          // Oculta o formulário atual
    }

    // Método para voltar ao formulário anterior
    public static void GoBack(Form currentForm)
    {
        if (formStack.Count > 0)
        {
            Form previousForm = formStack.Pop(); // Remove o último formulário da pilha
            previousForm.Show();                 // Mostra o formulário anterior
            currentForm.Close();                 // Fecha o formulário atual
        }
        else
        {
            MessageBox.Show("Não há formulários anteriores na pilha.");
        }
    }
}
