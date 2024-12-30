# Getting-Started-with-MAUI-Bottom-Sheet

This sample demonstrates how to get started with the MAUI Bottom Sheet control in a .NET MAUI application.

## Sample

```xaml
<Grid>
    <ListView ItemsSource="{Binding Books}" ItemTapped="ListViewItemTapped"
              HasUnevenRows="True">
        <ListView.ItemTemplate>
            <DataTemplate>
                <ViewCell>
                    <VerticalStackLayout Padding="10">
                        <Label Text="{Binding Title}" FontSize="20" FontAttributes="Bold"/>
                        <Label Text="{Binding Description}" FontSize="14" 
                               TextColor="Gray"/>
                    </VerticalStackLayout>
                </ViewCell>
            </DataTemplate>
        </ListView.ItemTemplate>
    </ListView>

    <bottomSheet:SfBottomSheet x:Name="bottomSheet" HalfExpandedRatio="0.35">
        <bottomSheet:SfBottomSheet.BottomSheetContent>
            <VerticalStackLayout x:Name="bottomSheetContent" Spacing="5">
                <Grid ColumnDefinitions="120,*" ColumnSpacing="10">
                    <Label Text="Title:" FontSize="18" FontAttributes="Bold"/>
                    <Label Text="{Binding Title}" FontSize="18" 
                           VerticalTextAlignment="Center" Grid.Column="1"/>
                </Grid>
                <Grid ColumnDefinitions="120, *" ColumnSpacing="10">
                    <Label Text="Genre:" FontSize="18" FontAttributes="Bold"/>
                    <Label Text="{Binding Genre}" FontSize="18" VerticalTextAlignment="Center" Grid.Column="1"/>
                </Grid>
                <Grid ColumnDefinitions="120, *" ColumnSpacing="10">
                    <Label Text="Published:" FontSize="18" FontAttributes="Bold"/>
                    <Label Text="{Binding Published}" FontSize="18" VerticalTextAlignment="Center" Grid.Column="1"/>
                </Grid>
                <Grid ColumnDefinitions="120, *" ColumnSpacing="10">
                    <Label Text="Description:" FontSize="18" FontAttributes="Bold"/>
                    <Label Text="{Binding Description}" FontSize="18" VerticalTextAlignment="Center" Grid.Column="1"/>
                </Grid>
                <Grid ColumnDefinitions="120,*" ColumnSpacing="10">
                    <Label Text="Price:" FontSize="18" FontAttributes="Bold"/>
                    <Label FontSize="18" VerticalTextAlignment="Center" Grid.Column="1">
                        <Label.FormattedText>
                            <FormattedString>
                                <Span Text="$" FontAttributes="Bold"/>
                                <Span Text="{Binding Price, StringFormat='{0:F2}'}"/>
                            </FormattedString>
                        </Label.FormattedText>
                    </Label>
                </Grid> 
            </VerticalStackLayout>
        </bottomSheet:SfBottomSheet.BottomSheetContent>
    </bottomSheet:SfBottomSheet>
</Grid>
```

## Requirements to run the demo

To run the demo, refer to [System Requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements)

## Troubleshooting:
### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion's samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion's samples.

