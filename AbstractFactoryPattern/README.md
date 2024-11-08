# Modular Smart Home Automation System

## Exercise Objective

Design a modular smart home automation platform capable of creating different types of smart devices (e.g., lights, thermostats, and cameras) from various brands. Each brand supports specific variations and settings for its devices. The goal is to implement an **Abstract Factory Pattern** to manage different families of devices, allowing easy customization based on brand and device type.

## Requirements

### Device Types and Properties

The system should support multiple types of smart devices, each with unique properties and behaviors:

- **Lights**
  - Properties: Brightness, color, on/off state
  - Behaviors: Adjust brightness, change color, turn on/off

- **Thermostats**
  - Properties: Temperature, mode (e.g., cool, heat), fan speed
  - Behaviors: Set temperature, change mode, adjust fan speed

- **Cameras**
  - Properties: Resolution, night mode, angle of view
  - Behaviors: Change resolution, toggle night mode, rotate camera angle

Each device should have unique ways to interact with its properties, ensuring an intuitive user experience for controlling device settings.

### Factory System

The system should use an **Abstract Factory Pattern** to manage the creation of device families:

1. **Abstract Factory**: Define an interface for creating each type of smart device (Light, Thermostat, Camera).
2. **Brand Factories**: Each brand should implement its own factory, which creates brand-specific devices:
   - BrandXFactory will create BrandX-specific Lights, Thermostats, and Cameras.
   - BrandYFactory will create BrandY-specific Lights, Thermostats, and Cameras.

This factory-based design ensures flexibility, allowing devices from different brands to be swapped or added without modifying existing code.

### Key Features of the Factory System

- **Modularity**: Each brand's factory can be developed and extended independently.
- **Scalability**: New device types or brands can be added easily by creating additional factories.
- **Encapsulation**: Device properties and behaviors are encapsulated within brand-specific classes, adhering to the **Open/Closed Principle**.
- **Ease of Integration**: The system allows users to switch between brands seamlessly, as each brand's factory provides the appropriate device family according to the input.

## Example Structure

1. **AbstractFactory**: Interface defining methods to create Lights, Thermostats, and Cameras.
2. **BrandXFactory** and **BrandYFactory**: Implementations of the Abstract Factory that produce BrandX and BrandY devices respectively.
3. **Device Interfaces (e.g., Light, Thermostat, Camera)**: Define the common behaviors and properties across all devices of that type.
4. **Concrete Device Classes (e.g., BrandXLight, BrandYThermostat)**: Implementations of the device interfaces, customized per brand.

