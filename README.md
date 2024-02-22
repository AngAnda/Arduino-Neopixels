# Arduino-Neopixels-Interface

This C# application provides a user-friendly interface for selecting colors and patterns for NeoPixel LED strips using serial communication.

## Features

- **Color Selection**: Choose colors via a color picker or RGB code input for your NeoPixel strip.
- **Light Power Control**: Adjust the intensity of the light with a slider.
- **Color Sample**: Preview the selected color before sending it to the NeoPixel strip.
- **Pattern Customization**: Create and customize LED patterns with adjustable delay times and the number of lit LEDs.
- **Rotative Pattern Option**: Enable or disable rotative patterns.
- **Default Pattern Selection**: Choose from a set of predefined LED patterns.
- **Pattern Creation**: Define and name new patterns for the LED strip.
- **Pattern Preview**: Preview the created patterns before applying them.
- **Serial Communication**: Send the selected color or pattern to the Arduino controlling the NeoPixel strip via a serial connection.

## Interface Elements

- **Rgb Code**: Input the RGB values for the desired color.
- **Pattern Code**: Define the pattern code for the LEDs.
- **Final Code**: Automatically generated code that combines RGB and pattern values to be sent to the Arduino.
- **Send to Arduino**: Button to send the final code through serial communication to the NeoPixel strip.
- **Advanced Properties / Help**: Access additional settings and help documentation.

## Using the Application

1. Connect your NeoPixel LED strip to an Arduino.
2. Launch the application and connect to the Arduino via the correct COM port.
3. Select the color using the RGB code input or the color picker.
4. Customize the pattern as desired using the pattern customization tools.
5. Click 'Send to Arduino' to update the LED strip with the new color or pattern.
6. Use 'Advanced Properties' for further configuration or 'Help' for assistance with the application.

![image](https://github.com/AngAnda/Arduino-Neopixels/assets/61116472/6a897a23-e118-428c-af56-c0d8276979d3)

In the Advanced Options section, the user can opt for a pre-set pattern or can create their own custom design.

![image](https://github.com/AngAnda/Arduino-Neopixels/assets/61116472/fb120e3b-9cc6-4337-ad37-669fb2e714a8)

