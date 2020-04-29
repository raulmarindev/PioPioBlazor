namespace PioPioBlazor.Components
{
    public class TagSelectorStyle
    {
        public static readonly TagSelectorStyle TailwindCss = new TagSelectorStyle
        {
            SelectorClass = "block appearance-none w-full bg-white border border-gray-400 hover:border-gray-500 px-4 py-2 pr-8 rounded shadow leading-tight focus:outline-none focus:shadow-outline mb-8",
            SelectedTagClass = "bg-blue-300 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded-full",
            DropdownClass = "bg-white shadow rounded-lg py-2",
            DropdownItemClass = "block px-4 py-2 text-gray-80 hover:bg-indigo-500",
            DropdownItemHoverClass = "bg-indigo-500",
            InputboxClass = "",
            RemoveTagClass = "fas fa-times"
        };

        public string SelectorClass { get; set; } = string.Empty;
        public string SelectedTagClass { get; set; } = string.Empty;
        public string DropdownClass { get; set; } = string.Empty;
        public string DropdownItemClass { get; set; } = string.Empty;
        public string DropdownItemHoverClass { get; set; } = string.Empty;
        public string InputboxClass { get; set; } = string.Empty;
        public string RemoveTagClass { get; set; } = string.Empty;
    }
}