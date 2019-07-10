# FControls
This is a .NET library containing some Windows Forms Controls with custom design.

## FButton
This is a simple button control. It has rounded bounds and the background can be painted with a gradient or a single color.
Beyond the Control class properties, it has the following properties:

!(fbutton)[https://github.com/FilipeChagasDev/FControls/blob/master/GitHubImages/fbutton.gif]

| Property name     | Description   |
|:-----------------:|:-------------:|
| bool GradientFill | Set true if you want to paint the background with a gradient. If you set it as false, the background will be painted with a single color.|
| int BorderRadius  | Radius of the border rounding |
| Color TopColor    | Single color or top color (gradient) of the background. |
| Color BottomColor | Bottom color of the background gradient. |
| Color MouseEnterTopColor | Single color or top color (gradient) of the background when the mouse is inside the button. |
| Color MouseEnterBottomColor | Bottom color of the background gradient when the mouse is inside the button. |
| byte MouseEnterLightness | Lightness variation of the background when the mouse enters the button area |
| MouseEnterMutationEnum MouseEnterMutation | Choose which background change will be made when the mouse enters the area (ChangeColor or ChangeLightness). |
| Color ClickContourColor | Contour color when the mouse click |
