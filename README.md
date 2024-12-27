# Getting-Started-with-MAUI-Bottom-Sheet

This sample demonstrates how to get started with the MAUI Bottom Sheet control in a .NET MAUI application.

## Sample

```xaml
<bottomSheet:SfBottomSheet x:Name="bottomSheet" AllowedState="HalfExpanded"
                           IsModal="False">
    <bottomSheet:SfBottomSheet.Content>
        <VerticalStackLayout Padding="20">
            <Button Text="Open Bottom Sheet" Clicked="OpenBottomSheet"
                    WidthRequest="180" CornerRadius="30" VerticalOptions="Center"/>
        </VerticalStackLayout>
    </bottomSheet:SfBottomSheet.Content>
    <bottomSheet:SfBottomSheet.BottomSheetContent>
        <Label Text="Bottom Sheet Content" HorizontalOptions="Center"
               VerticalOptions="Center" FontSize="18"/>
    </bottomSheet:SfBottomSheet.BottomSheetContent>
</bottomSheet:SfBottomSheet>
```

## Requirements to run the demo

To run the demo, refer to [System Requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements)

## Troubleshooting:
### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion's samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion's samples.

