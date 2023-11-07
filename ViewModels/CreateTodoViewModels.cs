using System;
using Flunt.Notifications;
using Flunt.Validations;

namespace MiniTodo.ViewModels
{
    public class CreateTodoViewModel : Notifiable<Notification>
    {
        public required string Title { get; set; }

        public Todo? MapTo()
        {
            var contract = new Contract<Notification>()
                .Requires()
                .IsNotNullOrEmpty(Title, "Title", "Informe o Título da Tarefa")
                .IsGreaterOrEqualsThan(Title.Length, 3, "Title", "O título deve conter pelo menos 3 caracteres");

            if (contract.IsValid)
            {
                AddNotifications(contract.Notifications);
                return new Todo(Guid.NewGuid(), Title, false); // Crie um novo objeto Todo se a validação for bem-sucedida.
            }

            return null; // Retorna null em caso de validação inválida.
        }
    }
}
