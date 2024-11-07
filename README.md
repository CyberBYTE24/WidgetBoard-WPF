# Widget Board (WPF)
 | ReadMe | [Documentation](ExperimentalProject/Documentation.md) | 

## Description

This WPF component library provides a WidgetBoard component on which you can implement a user interface that allows the user to position and scale your UserControl within its field.

![](Assets/Demo.gif)

## Composition of the solution

- WidgetBoard Library
- Example of a library for implementing widgets for a board
- Example of implementing WidgetBoard with getting widgets from a library

## Functional

This solution can:
- bind the location and scale of widgets to the grid
- provide custom grid dimensions and cell sizes
- make the cell size adaptive to the size of the WPF element
- accept color schemes via properties
- pass user settings to widget instances
- serialize and deserialize the location of widgets and their settings
- save and restore the position of widgets and their settings when opened
