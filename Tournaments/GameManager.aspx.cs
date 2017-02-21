﻿using Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tournaments.Models;
using Tournaments.Models_project;
using Tournaments.Presenters;
using Tournaments.Views;
using WebFormsMvp;
using WebFormsMvp.Web;

namespace Tournaments
{
    [PresenterBinding(typeof(GamePresenter))]
    public partial class GameManager : MvpPage<GameViewModel>, IGameView
    {
        public event EventHandler MyInit;
        public event EventHandler OnGetData;
        public event EventHandler OnInsertItem;
        public event EventHandler<IdEventArgs> OnDeleteItem;
        public event EventHandler<IdEventArgs> OnUpdateItem;

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression

        public IQueryable<Game> GridViewGames_GetData()
        {
            this.OnGetData?.Invoke(this, null);

            return this.Model.Games.AsQueryable();
        }

        public void GridViewGames_InsertItem()
        {
            this.OnInsertItem?.Invoke(this, null);
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void GridViewGames_DeleteItem(int? id)
        {

            this.OnDeleteItem?.Invoke(this, new IdEventArgs(id));
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void GridViewGames_UpdateItem(int? id)
        {
            this.OnUpdateItem?.Invoke(this, new IdEventArgs(id));
        }

    }
}