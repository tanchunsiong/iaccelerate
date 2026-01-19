# iAccelerate - Car Performance Analyzer

Windows Forms application that uses Phidgets accelerometer hardware to measure vehicle performance metrics. Calculates 0-60 time, quarter-mile performance, horsepower estimates, and other acceleration statistics for automotive enthusiasts.

Developed for Microsoft Imagine Cup 2007-2008 competition.

## Features

- Real-time acceleration measurement using Phidgets accelerometer
- 0-60 MPH time calculation
- Quarter-mile elapsed time and trap speed
- Horsepower estimation from acceleration data
- Distance traveled tracking
- Kinematic calculations (velocity, displacement)
- Data logging to file (grid and trace data)
- Configurable acceleration detection threshold
- User-friendly graphical interface

## Tech Stack

- **Platform**: Windows Forms, .NET Framework
- **Language**: C#
- **Hardware**: Phidgets USB Accelerometer (3-axis)
- **Libraries**: Phidget21.NET.dll

## Hardware Requirements

- **Phidgets 3-Axis Accelerometer** (Model 1059 or similar)
- USB connection to Windows PC
- Mounting bracket for vehicle installation
- Laptop with USB port (or tablet/netbook)

## Installation

1. Install Phidgets drivers from phidgets.com
2. Connect Phidgets accelerometer to USB port
3. Mount accelerometer in vehicle (aligned with driving direction)
4. Open `iAccelerate.sln` in Visual Studio
5. Build and run application

## Usage

### Setup
1. Launch application
2. Click "Setup" button
3. Configure:
   - Vehicle weight (for horsepower calculation)
   - Acceleration threshold (default 0.02 g)
   - File logging options

### Measurement
1. Position vehicle at starting point
2. Click "Start" or wait for automatic detection
3. Accelerate vehicle
4. Application measures and displays:
   - Current speed (MPH)
   - Current acceleration (g-force)
   - Elapsed time
   - Distance traveled
   - Estimated horsepower
5. Results saved automatically

### Calibration
- Zero accelerometer on level ground before run
- Ensure sensor aligned with vehicle longitudinal axis
- Adjust threshold if false starts occur

## Calculations

### Velocity
```
v = v₀ + ∫ a dt
```
Integrates acceleration over time to calculate instantaneous velocity.

### Distance
```
s = s₀ + ∫ v dt  
```
Integrates velocity over time to calculate distance traveled.

### Horsepower (Estimated)
```
HP = (Weight × Velocity × Acceleration) / 375
```
Simplified formula using weight, instantaneous velocity, and acceleration.

## Accuracy

- **0-60 Time**: ±0.1 seconds (with proper calibration)
- **Quarter-Mile**: ±0.2 seconds
- **Speed**: ±2 MPH
- **Horsepower**: ±10% (rough estimate)

Accuracy depends on:
- Accelerometer mounting stability
- Sensor calibration
- Road surface conditions (slope, traction)
- Tire slip minimal assumption

## License

MIT License

## Links

- Blog post: [iAccelerate: Vehicle Performance Analyzer with USB Accelerometer](https://www.tanchunsiong.com/2008/02/iaccelerate-vehicle-performance-analyzer-with-usb-accelerometer/)
- GitHub: [github.com/tanchunsiong](https://github.com/tanchunsiong)
- LinkedIn: [linkedin.com/in/tanchunsiong](https://linkedin.com/in/tanchunsiong)
- X: [x.com/tanchunsiong](https://x.com/tanchunsiong)

**Project Created:** 2007-2008 (Imagine Cup / SP Year 2 Sem 2)
