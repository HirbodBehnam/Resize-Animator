# Resize Animator
Animate the resizing of an application. Supports Windows Forms, Console Application and WPF Application.

## Usage

#### Changing Windows Form Size
  ```cs
//Change windows form size to 550×380 with default speed
ResizeAnimator.WindowsForm.Resize(this,550,380);
//Change windows form size to 550×380 with ×3 speed
ResizeAnimator.WindowsForm.Resize(this,550,380,3);
  ```
#### Changing Console Application Buffer Size
  ```cs
//Change console buffer size to 300×300 with default speed
ResizeAnimator.ConsoleApplication.BufferResize(300,300);
//Change console windows size to 80×35 with default speed
ResizeAnimator.ConsoleApplication.WindowResizer(80,35);
  ```
  
  **Warning:**Using ```ResizeAnimator.ConsoleApplication.WindowResizer``` may throw an Argument Out Of Range Exception.
  
### Compatibility
- VB.Net and C#.Net
- .Net Framework 3.0
