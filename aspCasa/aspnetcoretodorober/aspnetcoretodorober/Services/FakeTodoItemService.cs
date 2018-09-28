using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using aspnetcoretodorober.Models;

namespace aspnetcoretodorober.Services
{
    public class FakeTodoItemService
    {
       public class FakeTodoItemService : ITodoItemService
       {
           public Task<TodoItem[]> GetIncompleteItemsAsync()
           {
               var item1 = new TodoItem
           }
       } 
    }
}