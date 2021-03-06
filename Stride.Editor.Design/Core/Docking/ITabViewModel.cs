﻿namespace Stride.Editor.Design.Core
{
    public interface ITabViewModel
    {
        /// <summary>
        /// ViewModel associated with the contents of this tab.
        /// </summary>
        object ViewModel { get; }

        /// <summary>
        /// Id of the tab.
        /// </summary>
        string Id { get; }

        /// <summary>
        /// Title of the tab.
        /// </summary>
        string Title { get; }

        bool RequiresViewRefresh { get; set; }
    }
}