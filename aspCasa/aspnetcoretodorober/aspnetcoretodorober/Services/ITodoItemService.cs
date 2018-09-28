using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using aspnetcoretodorober.Models;

namespace AspNetCoreTodo.Services
{
    public interface ITodoItemService
    {
        Task<TodoItem[]> GetIncompleteItemsAsync();
    }
}