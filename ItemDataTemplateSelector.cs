namespace CarouselLeaks;

internal class ItemDataTemplateSelector : DataTemplateSelector
{
	public DataTemplate ItemTemplate { get; set; }

	protected override DataTemplate OnSelectTemplate(object item, BindableObject container) => ItemTemplate;
}
