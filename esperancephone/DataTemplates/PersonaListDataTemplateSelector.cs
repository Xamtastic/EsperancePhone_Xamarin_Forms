﻿using System;
using esperancephone.DataTemplates.ContactListCells;
using esperancephone.DataTemplates.PersonaListCells;
using esperancephone.Models;
using esperancephone.ViewModels;
using esperancephone.Views;
using Xamarin.Forms;

namespace esperancephone.DataTemplates
{
    public class PersonaListDataTemplateSelector : Xamarin.Forms.DataTemplateSelector
    {
        public PersonaListDataTemplateSelector()
        {
            this._personasGroupHeadingCell = new DataTemplate(typeof(PersonasGroupHeadingCell));
            this._displayNameCell = new DataTemplate(typeof(PersonaListCells.DisplayNameCell));
            this._phoneNumberCell = new DataTemplate(typeof(PhoneNumberCell));
            this._personaCell = new DataTemplate(typeof(PersonaListCell));
            this._communicateCell = new DataTemplate(typeof(CommunicateCell));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            DataTemplate response = null;

            var viewModel = item as PersonaListItemViewModel;
            if (viewModel == null) return null;

            switch (viewModel.TemplateSelectorType)
            {
                case PersonaListItemType.DisplayName:
                    response = _displayNameCell;
                    break;
                case PersonaListItemType.PhoneNumber:
                    response = _phoneNumberCell;
                    break;
                case PersonaListItemType.Personas:
                    response = _personaCell;
                    break;
                case PersonaListItemType.Communicate:
                    response = _communicateCell;
                    break;
                case PersonaListItemType.PersonasGroupHeading:
                    response = _personasGroupHeadingCell;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return response;
        }

        private readonly DataTemplate _personasGroupHeadingCell;
        private readonly DataTemplate _displayNameCell;
        private readonly DataTemplate _phoneNumberCell;
        private readonly DataTemplate _personaCell;
        private readonly DataTemplate _communicateCell;

    }
}