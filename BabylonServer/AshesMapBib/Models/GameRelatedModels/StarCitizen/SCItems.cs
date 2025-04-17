using Models.RSIShopModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
namespace AshesMapBib.Models.GameRelatedModels.StarCitizen
{

    public class AfterburnAccelMultiplier
    {
        [JsonProperty("x")]
        [JsonPropertyName("x")]
        public double? X { get; set; }

        [JsonProperty("y")]
        [JsonPropertyName("y")]
        public double? Y { get; set; }

        [JsonProperty("z")]
        [JsonPropertyName("z")]
        public double? Z { get; set; }
    }
    public class Localization
    {
        public string nam { get; set; }
        public string des { get; set; }
    }
    public class AfterburnAngAccelMultiplier
    {
        [JsonProperty("x")]
        [JsonPropertyName("x")]
        public double? X { get; set; }

        [JsonProperty("y")]
        [JsonPropertyName("y")]
        public double? Y { get; set; }

        [JsonProperty("z")]
        [JsonPropertyName("z")]
        public double? Z { get; set; }
    }

    public class Afterburner
    {
        [JsonProperty("afterburnerSpoolUpTime")]
        [JsonPropertyName("afterburnerSpoolUpTime")]
        public double? AfterburnerSpoolUpTime { get; set; }

        [JsonProperty("afterburnerCapacitorThresholdRatio")]
        [JsonPropertyName("afterburnerCapacitorThresholdRatio")]
        public double? AfterburnerCapacitorThresholdRatio { get; set; }

        [JsonProperty("capacitorMax")]
        [JsonPropertyName("capacitorMax")]
        public int? CapacitorMax { get; set; }

        [JsonProperty("capacitorAfterburnerIdleCost")]
        [JsonPropertyName("capacitorAfterburnerIdleCost")]
        public int? CapacitorAfterburnerIdleCost { get; set; }

        [JsonProperty("capacitorRegenDelayAfterUse")]
        [JsonPropertyName("capacitorRegenDelayAfterUse")]
        public double? CapacitorRegenDelayAfterUse { get; set; }

        [JsonProperty("capacitorRegenPerSec")]
        [JsonPropertyName("capacitorRegenPerSec")]
        public double? CapacitorRegenPerSec { get; set; }

        [JsonProperty("afterburnAccelMultiplier")]
        [JsonPropertyName("afterburnAccelMultiplier")]
        public AfterburnAccelMultiplier AfterburnAccelMultiplier { get; set; }

        [JsonProperty("afterburnAngAccelMultiplier")]
        [JsonPropertyName("afterburnAngAccelMultiplier")]
        public AfterburnAngAccelMultiplier AfterburnAngAccelMultiplier { get; set; }
    }

    public class AngularVelocity
    {
        [JsonProperty("x")]
        [JsonPropertyName("x")]
        public double? Pitch { get; set; }

        [JsonProperty("y")]
        [JsonPropertyName("y")]
        public double? Roll { get; set; }

        [JsonProperty("z")]
        [JsonPropertyName("z")]
        public double? Yaw { get; set; }
    }

    public class Armor
    {
        [JsonProperty("calculatorType")]
        [JsonPropertyName("calculatorType")]
        public string CalculatorType { get; set; }

        [JsonProperty("data")]
        [JsonPropertyName("data")]
        public IgItem Data { get; set; }

        [JsonProperty("localName")]
        [JsonPropertyName("localName")]
        public string LocalName { get; set; }

        [JsonProperty("signalInfrared")]
        [JsonPropertyName("signalInfrared")]
        public double? SignalInfrared { get; set; }

        [JsonProperty("signalElectromagnetic")]
        [JsonPropertyName("signalElectromagnetic")]
        public double? SignalElectromagnetic { get; set; }

        [JsonProperty("signalCrossSection")]
        [JsonPropertyName("signalCrossSection")]
        public double? SignalCrossSection { get; set; }

        [JsonProperty("damageMultiplier")]
        [JsonPropertyName("damageMultiplier")]
        public DamageMultiplier DamageMultiplier { get; set; }
    }

    public class Capacitor
    {
        [JsonProperty("minAssignment")]
        [JsonPropertyName("minAssignment")]
        public int? MinAssignment { get; set; }

        [JsonProperty("maxAssignment")]
        [JsonPropertyName("maxAssignment")]
        public int? MaxAssignment { get; set; }
    }

    public class Cargo
    {
        [JsonProperty("calculatorType")]
        [JsonPropertyName("calculatorType")]
        public string CalculatorType { get; set; }

        [JsonProperty("data")]
        [JsonPropertyName("data")]
        public IgItem Data { get; set; }

        [JsonProperty("localName")]
        [JsonPropertyName("localName")]
        public string LocalName { get; set; }
    }

    public class CargoGrid
    {
        [JsonProperty("crateGenPercentageOnDestroy")]
        [JsonPropertyName("crateGenPercentageOnDestroy")]
        public double? CrateGenPercentageOnDestroy { get; set; }

        [JsonProperty("crateMaxOnDestroy")]
        [JsonPropertyName("crateMaxOnDestroy")]
        public int? CrateMaxOnDestroy { get; set; }

        [JsonProperty("personalInventory")]
        [JsonPropertyName("personalInventory")]
        public int? PersonalInventory { get; set; }

        [JsonProperty("invisible")]
        [JsonPropertyName("invisible")]
        public bool Invisible { get; set; }

        [JsonProperty("miningOnly")]
        [JsonPropertyName("miningOnly")]
        public bool MiningOnly { get; set; }

        [JsonProperty("minVolatilePowerToExplode")]
        [JsonPropertyName("minVolatilePowerToExplode")]
        public int? MinVolatilePowerToExplode { get; set; }

        [JsonProperty("x")]
        [JsonPropertyName("x")]
        public double? X { get; set; }

        [JsonProperty("y")]
        [JsonPropertyName("y")]
        public double? Y { get; set; }

        [JsonProperty("z")]
        [JsonPropertyName("z")]
        public double? Z { get; set; }

        [JsonProperty("scus")]
        [JsonPropertyName("scus")]
        public double? Scus { get; set; }
    }

    public class Controller
    {
        [JsonProperty("calculatorType")]
        [JsonPropertyName("calculatorType")]
        public string CalculatorType { get; set; }

        [JsonProperty("data")]
        [JsonPropertyName("data")]
        public IgItem Data { get; set; }

        [JsonProperty("localName")]
        [JsonPropertyName("localName")]
        public string LocalName { get; set; }
    }

    public class DamageMultiplier
    {
        [JsonProperty("damagePhysical")]
        [JsonPropertyName("damagePhysical")]
        public double? DamagePhysical { get; set; }

        [JsonProperty("damageEnergy")]
        [JsonPropertyName("damageEnergy")]
        public double? DamageEnergy { get; set; }

        [JsonProperty("damageDistortion")]
        [JsonPropertyName("damageDistortion")]
        public double? DamageDistortion { get; set; }

        [JsonProperty("damageThermal")]
        [JsonPropertyName("damageThermal")]
        public int? DamageThermal { get; set; }

        [JsonProperty("damageBiochemical")]
        [JsonPropertyName("damageBiochemical")]
        public int? DamageBiochemical { get; set; }

        [JsonProperty("damageStun")]
        [JsonPropertyName("damageStun")]
        public int? DamageStun { get; set; }
    }

    public class Dashboard
    {
        [JsonProperty("calculatorType")]
        [JsonPropertyName("calculatorType")]
        public string CalculatorType { get; set; }

        [JsonProperty("data")]
        [JsonPropertyName("data")]
        public IgItem Data { get; set; }

        [JsonProperty("localName")]
        [JsonPropertyName("localName")]
        public string LocalName { get; set; }
    }

    public class IgItem
    {
        [JsonProperty("health")]
        [JsonPropertyName("health")]
        public double? Health { get; set; }

        [JsonProperty("maxLifetimeHours")]
        [JsonPropertyName("maxLifetimeHours")]
        public double? MaxLifetimeHours { get; set; }

        [JsonProperty("type")]
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonProperty("subType")]
        [JsonPropertyName("subType")]
        public string SubType { get; set; }

        [JsonProperty("size")]
        [JsonPropertyName("size")]
        public int? Size { get; set; }

        [JsonProperty("grade")]
        [JsonPropertyName("grade")]
        public string Grade { get; set; }

        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonProperty("shortName")]
        [JsonPropertyName("shortName")]
        public string ShortName { get; set; }

        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonProperty("mass")]
        [JsonPropertyName("mass")]
        public double? Mass { get; set; }

        [JsonProperty("ref")]
        [JsonPropertyName("ref")]
        public string Ref { get; set; }

        [JsonProperty("heat")]
        [JsonPropertyName("heat")]
        public Heat Heat { get; set; }

        [JsonProperty("power")]
        [JsonPropertyName("power")]
        public Power Power { get; set; }

        [JsonProperty("distortion")]
        [JsonPropertyName("distortion")]
        public Distortion Distortion { get; set; }

        [JsonProperty("weapon")]
        [JsonPropertyName("weapon")]
        public Weapon Weapon { get; set; }

        [JsonProperty("ammoContainer")]
        [JsonPropertyName("ammoContainer")]
        public AmmoContainer AmmoContainer { get; set; }

        [JsonProperty("loadout")]
        [JsonPropertyName("loadout")]
        public List<Loadout> Loadout { get; set; }

        [JsonProperty("ammo")]
        [JsonPropertyName("ammo")]
        public Ammo Ammo { get; set; }

        [JsonProperty("group")]
        [JsonPropertyName("group")]
        public string Group { get; set; }

        [JsonProperty("manufacturerData")]
        [JsonPropertyName("manufacturerData")]
        public ManufacturerData ManufacturerData { get; set; }

        [JsonProperty("requiredTags")]
        [JsonPropertyName("requiredTags")]
        public string RequiredTags { get; set; }

        [JsonProperty("modifier")]
        [JsonPropertyName("modifier")]
        public Modifier Modifier { get; set; }

        [JsonProperty("fuelTank")]
        [JsonPropertyName("fuelTank")]
        public FuelTank FuelTank { get; set; }

        [JsonProperty("manufacturerRef")]
        [JsonPropertyName("manufacturerRef")]
        public string ManufacturerRef { get; set; }

        [JsonProperty("ports")]
        [JsonPropertyName("ports")]
        public List<Port> Ports { get; set; }

        [JsonProperty("location")]
        [JsonPropertyName("location")]
        public string Location { get; set; }

        [JsonProperty("inventory")]
        [JsonPropertyName("inventory")]
        public Inventory Inventory { get; set; }

        [JsonProperty("rental")]
        [JsonPropertyName("rental")]
        public bool? Rental { get; set; }

        [JsonProperty("shield")]
        [JsonPropertyName("shield")]
        public Shield Shield { get; set; }

        [JsonProperty("class")]
        [JsonPropertyName("class")]
        public string Class { get; set; }

        [JsonProperty("projectile")]
        [JsonPropertyName("projectile")]
        public Projectile Projectile { get; set; }

        [JsonProperty("damage")]
        [JsonPropertyName("damage")]
        public Damage Damage { get; set; }

        [JsonProperty("pierceability")]
        [JsonPropertyName("pierceability")]
        public Pierceability Pierceability { get; set; }

        [JsonProperty("ammoCategory")]
        [JsonPropertyName("ammoCategory")]
        public string AmmoCategory { get; set; }

        //[JsonProperty("hitPoints")]
        //[JsonPropertyName("hitPoints")]
        //public int? HitPoints { get; set; }

        [JsonProperty("lifetime")]
        [JsonPropertyName("lifetime")]
        public double? Lifetime { get; set; }

        [JsonProperty("showtime")]
        [JsonPropertyName("showtime")]
        public int? Showtime { get; set; }

        [JsonProperty("inheritVelocity")]
        [JsonPropertyName("inheritVelocity")]
        public bool InheritVelocity { get; set; }

        [JsonProperty("speed")]
        [JsonPropertyName("speed")]
        public int? Speed { get; set; }

        [JsonProperty("explosion")]
        [JsonPropertyName("explosion")]
        public Explosion Explosion { get; set; }

        [JsonProperty("nameSmall")]
        [JsonPropertyName("nameSmall")]
        public string NameSmall { get; set; }

        [JsonProperty("calculatorName")]
        [JsonPropertyName("calculatorName")]
        public string CalculatorName { get; set; }


        [JsonProperty("vehicle")]
        [JsonPropertyName("vehicle")]
        public Vehicle Vehicle { get; set; }

        [JsonProperty("hull")]
        [JsonPropertyName("hull")]
        public Hull Hull { get; set; }

        [JsonProperty("items")]
        [JsonPropertyName("items")]
        public Items Items { get; set; }


        [JsonProperty("armor")]
        [JsonPropertyName("armor")]
        public Armor Armor { get; set; }

        [JsonProperty("ifcs")]
        [JsonPropertyName("ifcs")]
        public Ifcs Ifcs { get; set; }

        [JsonProperty("weaponRegenPoolCrew")]
        [JsonPropertyName("weaponRegenPoolCrew")]
        public WeaponRegenPoolCrew WeaponRegenPoolCrew { get; set; }

        [JsonProperty("capacitor")]
        [JsonPropertyName("capacitor")]
        public Capacitor Capacitor { get; set; }

        [JsonProperty("cargo")]
        [JsonPropertyName("cargo")]
        public double? Cargo { get; set; }

        [JsonProperty("fuelCapacity")]
        [JsonPropertyName("fuelCapacity")]
        public int? FuelCapacity { get; set; }

        [JsonProperty("qtFuelCapacity")]
        [JsonPropertyName("qtFuelCapacity")]
        public double? QtFuelCapacity { get; set; }

        [JsonProperty("weaponRegenPoolTurret")]
        [JsonPropertyName("weaponRegenPoolTurret")]
        public WeaponRegenPoolTurret WeaponRegenPoolTurret { get; set; }


        [JsonProperty("thruster")]
        [JsonPropertyName("thruster")]
        public Thruster Thruster { get; set; }


        [JsonProperty("cargoGrid")]
        [JsonPropertyName("cargoGrid")]
        public CargoGrid CargoGrid { get; set; }



        [JsonProperty("manufacturer")]
        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; set; }



        [JsonProperty("radar")]
        [JsonPropertyName("radar")]
        public Radar Radar { get; set; }

    }

    public class Distortion
    {
        [JsonProperty("decayDelay")]
        [JsonPropertyName("decayDelay")]
        public double? DecayDelay { get; set; }

        [JsonProperty("decayRate")]
        [JsonPropertyName("decayRate")]
        public double? DecayRate { get; set; }

        [JsonProperty("maximum")]
        [JsonPropertyName("maximum")]
        public double? Maximum { get; set; }

        [JsonProperty("warningRatio")]
        [JsonPropertyName("warningRatio")]
        public double? WarningRatio { get; set; }

        [JsonProperty("recoveryRatio")]
        [JsonPropertyName("recoveryRatio")]
        public double? RecoveryRatio { get; set; }

        [JsonProperty("powerRatioAtMaxDistortion")]
        [JsonPropertyName("powerRatioAtMaxDistortion")]
        public bool PowerRatioAtMaxDistortion { get; set; }

        [JsonProperty("powerChangeOnlyAtMaxDistortion")]
        [JsonPropertyName("powerChangeOnlyAtMaxDistortion")]
        public bool PowerChangeOnlyAtMaxDistortion { get; set; }
    }

    public class FuelIntake
    {
        [JsonProperty("calculatorType")]
        [JsonPropertyName("calculatorType")]
        public string CalculatorType { get; set; }

        [JsonProperty("data")]
        [JsonPropertyName("data")]
        public IgItem Data { get; set; }

        [JsonProperty("localName")]
        [JsonPropertyName("localName")]
        public string LocalName { get; set; }
    }

    public class FuelTank
    {
        [JsonProperty("calculatorType")]
        [JsonPropertyName("calculatorType")]
        public string CalculatorType { get; set; }

        [JsonProperty("data")]
        [JsonPropertyName("data")]
        public IgItem Data { get; set; }

        [JsonProperty("localName")]
        [JsonPropertyName("localName")]
        public string LocalName { get; set; }
    }

    public class FuelTank2
    {
        [JsonProperty("fillRate")]
        [JsonPropertyName("fillRate")]
        public int? FillRate { get; set; }

        [JsonProperty("drainRate")]
        [JsonPropertyName("drainRate")]
        public int? DrainRate { get; set; }

        [JsonProperty("capacity")]
        [JsonPropertyName("capacity")]
        public double? Capacity { get; set; }

        [JsonProperty("haltFuelBelowLevel")]
        [JsonPropertyName("haltFuelBelowLevel")]
        public double? HaltFuelBelowLevel { get; set; }

        [JsonProperty("continueFuelAboveLevel")]
        [JsonPropertyName("continueFuelAboveLevel")]
        public double? ContinueFuelAboveLevel { get; set; }
    }

    public class Heat
    {
        [JsonProperty("temperatureToIR")]
        [JsonPropertyName("temperatureToIR")]
        public double? TemperatureToIR { get; set; }

        [JsonProperty("startIRTemperature")]
        [JsonPropertyName("startIRTemperature")]
        public double? StartIRTemperature { get; set; }

        [JsonProperty("overpowerHeat")]
        [JsonPropertyName("overpowerHeat")]
        public double? OverpowerHeat { get; set; }

        [JsonProperty("overclockThresholdMinHeat")]
        [JsonPropertyName("overclockThresholdMinHeat")]
        public double? OverclockThresholdMinHeat { get; set; }

        [JsonProperty("overclockThresholdMaxHeat")]
        [JsonPropertyName("overclockThresholdMaxHeat")]
        public double? OverclockThresholdMaxHeat { get; set; }

        [JsonProperty("thermalEnergyBase")]
        [JsonPropertyName("thermalEnergyBase")]
        public double? ThermalEnergyBase { get; set; }

        [JsonProperty("thermalEnergyDraw")]
        [JsonPropertyName("thermalEnergyDraw")]
        public double? ThermalEnergyDraw { get; set; }

        [JsonProperty("thermalConductivity")]
        [JsonPropertyName("thermalConductivity")]
        public double? ThermalConductivity { get; set; }

        [JsonProperty("specificHeatCapacity")]
        [JsonPropertyName("specificHeatCapacity")]
        public double? SpecificHeatCapacity { get; set; }

        [JsonProperty("mass")]
        [JsonPropertyName("mass")]
        public double? Mass { get; set; }

        [JsonProperty("surfaceArea")]
        [JsonPropertyName("surfaceArea")]
        public double? SurfaceArea { get; set; }

        [JsonProperty("startCoolingTemperature")]
        [JsonPropertyName("startCoolingTemperature")]
        public double? StartCoolingTemperature { get; set; }

        [JsonProperty("maxCoolingRate")]
        [JsonPropertyName("maxCoolingRate")]
        public double? MaxCoolingRate { get; set; }

        [JsonProperty("maxTemperature")]
        [JsonPropertyName("maxTemperature")]
        public double? MaxTemperature { get; set; }

        [JsonProperty("overheatTemperature")]
        [JsonPropertyName("overheatTemperature")]
        public double? OverheatTemperature { get; set; }

        [JsonProperty("recoveryTemperature")]
        [JsonPropertyName("recoveryTemperature")]
        public double? RecoveryTemperature { get; set; }

        [JsonProperty("mdoubleemperature")]
        [JsonPropertyName("mdoubleemperature")]
        public double? Mdoubleemperature { get; set; }

        [JsonProperty("misfireMdoubleemperature")]
        [JsonPropertyName("misfireMdoubleemperature")]
        public double? MisfireMdoubleemperature { get; set; }

        [JsonProperty("misfireMaxTemperature")]
        [JsonPropertyName("misfireMaxTemperature")]
        public double? MisfireMaxTemperature { get; set; }
    }

    public class Hp
    {
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonProperty("hp")]
        [JsonPropertyName("hp")]
        public int? Hps { get; set; }
    }

    public class Hull
    {
        [JsonProperty("mass")]
        [JsonPropertyName("mass")]
        public double? Mass { get; set; }

        [JsonProperty("hp")]
        [JsonPropertyName("hp")]
        public List<Hp> Hp { get; set; }

        [JsonProperty("engineWarmupDelay")]
        [JsonPropertyName("engineWarmupDelay")]
        public int? EngineWarmupDelay { get; set; }

        [JsonProperty("engineIgnitionTime")]
        [JsonPropertyName("engineIgnitionTime")]
        public int? EngineIgnitionTime { get; set; }

        [JsonProperty("enginePowerMax")]
        [JsonPropertyName("enginePowerMax")]
        public double? EnginePowerMax { get; set; }

        [JsonProperty("rotationDamping")]
        [JsonPropertyName("rotationDamping")]
        public int? RotationDamping { get; set; }

        [JsonProperty("maxCruiseSpeed")]
        [JsonPropertyName("maxCruiseSpeed")]
        public int? MaxCruiseSpeed { get; set; }

        [JsonProperty("maxEngineThrust")]
        [JsonPropertyName("maxEngineThrust")]
        public int? MaxEngineThrust { get; set; }

        [JsonProperty("maxRetroThrust")]
        [JsonPropertyName("maxRetroThrust")]
        public int? MaxRetroThrust { get; set; }

        [JsonProperty("maxDirectionalThrust")]
        [JsonPropertyName("maxDirectionalThrust")]
        public int? MaxDirectionalThrust { get; set; }

        [JsonProperty("maxAngularVelocity")]
        [JsonPropertyName("maxAngularVelocity")]
        public List<int> MaxAngularVelocity { get; set; }

        [JsonProperty("maxAngularAcceleration")]
        [JsonPropertyName("maxAngularAcceleration")]
        public List<int> MaxAngularAcceleration { get; set; }

        [JsonProperty("maxJerk")]
        [JsonPropertyName("maxJerk")]
        public int? MaxJerk { get; set; }

        [JsonProperty("maxAngJerk")]
        [JsonPropertyName("maxAngJerk")]
        public int? MaxAngJerk { get; set; }

        [JsonProperty("maxTorqueAlpha")]
        [JsonPropertyName("maxTorqueAlpha")]
        public List<double> MaxTorqueAlpha { get; set; }

        [JsonProperty("maxTorqueAngle")]
        [JsonPropertyName("maxTorqueAngle")]
        public List<int> MaxTorqueAngle { get; set; }
    }

    public class Ifcs
    {
        [JsonProperty("maxSpeed")]
        [JsonPropertyName("maxSpeed")]
        public double? MaxSpeed { get; set; }

        [JsonProperty("maxAfterburnSpeed")]
        [JsonPropertyName("maxAfterburnSpeed")]
        public int? MaxAfterburnSpeed { get; set; }

        [JsonProperty("linearAccelDecay")]
        [JsonPropertyName("linearAccelDecay")]
        public double? LinearAccelDecay { get; set; }

        [JsonProperty("angularAccelDecay")]
        [JsonPropertyName("angularAccelDecay")]
        public double? AngularAccelDecay { get; set; }

        [JsonProperty("angularVelocity")]
        [JsonPropertyName("angularVelocity")]
        public AngularVelocity AngularVelocity { get; set; } = new();

        [JsonProperty("afterburner")]
        [JsonPropertyName("afterburner")]
        public Afterburner Afterburner { get; set; } = new();
        public int? YawMax { get; set; }
        public int? RollMax { get; set; }
        public int? PitchMax { get; set; }

    }

    public class Items
    {
        [JsonProperty("cargos")]
        [JsonPropertyName("cargos")]
        public List<Cargo> Cargos { get; set; }

        [JsonProperty("controllers")]
        [JsonPropertyName("controllers")]
        public List<Controller> Controllers { get; set; }

        [JsonProperty("dashboards")]
        [JsonPropertyName("dashboards")]
        public List<Dashboard> Dashboards { get; set; }

        [JsonProperty("fuelIntakes")]
        [JsonPropertyName("fuelIntakes")]
        public List<FuelIntake> FuelIntakes { get; set; }

        [JsonProperty("fuelTanks")]
        [JsonPropertyName("fuelTanks")]
        public List<FuelTank> FuelTanks { get; set; }

        [JsonProperty("modules")]
        [JsonPropertyName("modules")]
        public List<Module> Modules { get; set; }

        [JsonProperty("radars")]
        [JsonPropertyName("radars")]
        public List<Radar> Radars { get; set; }

        [JsonProperty("seats")]
        [JsonPropertyName("seats")]
        public List<Seat> Seats { get; set; }

        [JsonProperty("thrusters")]
        [JsonPropertyName("thrusters")]
        public List<Thruster> Thrusters { get; set; }
    }

    public class ItemType
    {
        [JsonProperty("type")]
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonProperty("subType")]
        [JsonPropertyName("subType")]
        public string SubType { get; set; }
    }

    public class Loadout
    {
        [JsonProperty("itemPortName")]
        [JsonPropertyName("itemPortName")]
        public string ItemPortName { get; set; }

        [JsonProperty("localName")]
        [JsonPropertyName("localName")]
        public string LocalName { get; set; }
        public IgItemRoot LocalItem { get; set; }

        [JsonProperty("minSize")]
        [JsonPropertyName("minSize")]
        public int? MinSize { get; set; }

        [JsonProperty("maxSize")]
        [JsonPropertyName("maxSize")]
        public int? MaxSize { get; set; }

        [JsonProperty("itemTypes")]
        [JsonPropertyName("itemTypes")]
        public List<ItemType> ItemTypes { get; set; }

        [JsonProperty("requiredTags")]
        [JsonPropertyName("requiredTags")]
        public string RequiredTags { get; set; }

        [JsonProperty("portTags")]
        [JsonPropertyName("portTags")]
        public string PortTags { get; set; }

        [JsonProperty("editable")]
        [JsonPropertyName("editable")]
        public bool? Editable { get; set; }

        [JsonProperty("loadout")]
        [JsonPropertyName("loadout")]
        public List<Loadout> Loadouts { get; set; }
        public Loadout FillWithItems(Loadout ldt, Dictionary<string, IgItemRoot> src)
        {
            if (src.ContainsKey(ldt.LocalName))
            {
                ldt.LocalItem = src[ldt.LocalName];
            }

            else
            {
                ldt.LocalItem = null;
            }


            return ldt;
        }

    }

    public class ManufacturerData
    {
        [JsonProperty("calculatorType")]
        [JsonPropertyName("calculatorType")]
        public string CalculatorType { get; set; }

        [JsonProperty("data")]
        [JsonPropertyName("data")]
        public IgItem Data { get; set; }
        public ManufacturerData CreateFromManuShort(ManufacturerShort from)
        {
            ManufacturerData data = new ManufacturerData();
            try
            {

                data.CalculatorType = from.Code;
                data.Data = new();
                data.Data.Name = from.Name;
                return data;
            }
            catch (Exception ex)
            {
                // Hier können Sie den Fehler loggen oder weiterleiten
                throw new Exception("Fehler beim Erstellen von ManufacturerData aus ManufacturerShort: " + ex.Message, ex);
            }
        }
    }

    public class Module
    {
        [JsonProperty("calculatorType")]
        [JsonPropertyName("calculatorType")]
        public string CalculatorType { get; set; }

        [JsonProperty("data")]
        [JsonPropertyName("data")]
        public IgItem Data { get; set; }

        [JsonProperty("localName")]
        [JsonPropertyName("localName")]
        public string LocalName { get; set; }
    }

    public class Port
    {
        [JsonProperty("minSize")]
        [JsonPropertyName("minSize")]
        public int? MinSize { get; set; }

        [JsonProperty("maxSize")]
        [JsonPropertyName("maxSize")]
        public int? MaxSize { get; set; }

        [JsonProperty("itemTypes")]
        [JsonPropertyName("itemTypes")]
        public List<ItemType> ItemTypes { get; set; }

        [JsonProperty("editable")]
        [JsonPropertyName("editable")]
        public bool? Editable { get; set; }
    }

    public class Power
    {
        [JsonProperty("powerBase")]
        [JsonPropertyName("powerBase")]
        public double? PowerBase { get; set; }

        [JsonProperty("powerDraw")]
        [JsonPropertyName("powerDraw")]
        public double? PowerDraw { get; set; }

        [JsonProperty("timeToReachDrawRequest")]
        [JsonPropertyName("timeToReachDrawRequest")]
        public double? TimeToReachDrawRequest { get; set; }

        [JsonProperty("safeguardPriority")]
        [JsonPropertyName("safeguardPriority")]
        public int? SafeguardPriority { get; set; }

        [JsonProperty("isThrottleable")]
        [JsonPropertyName("isThrottleable")]
        public bool IsThrottleable { get; set; }

        [JsonProperty("isOverclockable")]
        [JsonPropertyName("isOverclockable")]
        public bool IsOverclockable { get; set; }

        [JsonProperty("overclockThresholdMin")]
        [JsonPropertyName("overclockThresholdMin")]
        public double? OverclockThresholdMin { get; set; }

        [JsonProperty("overclockThresholdMax")]
        [JsonPropertyName("overclockThresholdMax")]
        public double? OverclockThresholdMax { get; set; }

        [JsonProperty("overpowerPerformance")]
        [JsonPropertyName("overpowerPerformance")]
        public double? OverpowerPerformance { get; set; }

        [JsonProperty("overclockPerformance")]
        [JsonPropertyName("overclockPerformance")]
        public double? OverclockPerformance { get; set; }

        [JsonProperty("powerToEM")]
        [JsonPropertyName("powerToEM")]
        public double? PowerToEM { get; set; }

        [JsonProperty("decayRateOfEM")]
        [JsonPropertyName("decayRateOfEM")]
        public double? DecayRateOfEM { get; set; }

        [JsonProperty("warningDelayTime")]
        [JsonPropertyName("warningDelayTime")]
        public double? WarningDelayTime { get; set; }

        [JsonProperty("warningDisplayTime")]
        [JsonPropertyName("warningDisplayTime")]
        public double? WarningDisplayTime { get; set; }
    }

    public class Radar
    {
        [JsonProperty("calculatorType")]
        [JsonPropertyName("calculatorType")]
        public string CalculatorType { get; set; }

        [JsonProperty("data")]
        [JsonPropertyName("data")]
        public IgItem Data { get; set; }

        [JsonProperty("localName")]
        [JsonPropertyName("localName")]
        public string LocalName { get; set; }
    }

    public class Radar2
    {
        [JsonProperty("identityDetection")]
        [JsonPropertyName("identityDetection")]
        public double? IdentityDetection { get; set; }

        [JsonProperty("pingCooldownTime")]
        [JsonPropertyName("pingCooldownTime")]
        public double? PingCooldownTime { get; set; }
    }

    public class IgItemRoot
    {
        [JsonProperty("calculatorType")]
        [JsonPropertyName("calculatorType")]
        public string CalculatorType { get; set; }

        [JsonProperty("data")]
        [JsonPropertyName("data")]
        public IgItem Data { get; set; }

        [JsonProperty("localName")]
        [JsonPropertyName("localName")]
        public string LocalName { get; set; }
    }

    public class Seat
    {
        [JsonProperty("calculatorType")]
        [JsonPropertyName("calculatorType")]
        public string CalculatorType { get; set; }

        [JsonProperty("data")]
        [JsonPropertyName("data")]
        public IgItem Data { get; set; }

        [JsonProperty("localName")]
        [JsonPropertyName("localName")]
        public string LocalName { get; set; }
    }

    public class Shield
    {
        [JsonProperty("faceType")]
        [JsonPropertyName("faceType")]
        public string FaceType { get; set; }

        [JsonProperty("shieldManagementAllowed")]
        [JsonPropertyName("shieldManagementAllowed")]
        public bool ShieldManagementAllowed { get; set; }

        [JsonProperty("MaxReallocation")]
        [JsonPropertyName("MaxReallocation")]
        public int? MaxReallocation { get; set; }

        [JsonProperty("minDamageStrengthRange")]
        [JsonPropertyName("minDamageStrengthRange")]
        public int? MinDamageStrengthRange { get; set; }

        [JsonProperty("maxDamageStrengthRange")]
        [JsonPropertyName("maxDamageStrengthRange")]
        public int? MaxDamageStrengthRange { get; set; }

        [JsonProperty("maxHitImpact")]
        [JsonPropertyName("maxHitImpact")]
        public int? MaxHitImpact { get; set; }
    }

    public class Size
    {
        [JsonProperty("x")]
        [JsonPropertyName("x")]
        public double? Lenght { get; set; }

        [JsonProperty("y")]
        [JsonPropertyName("y")]
        public double? Width { get; set; }

        [JsonProperty("z")]
        [JsonPropertyName("z")]
        public double? Height { get; set; }
    }

    public class Thruster
    {
        [JsonProperty("calculatorType")]
        [JsonPropertyName("calculatorType")]
        public string CalculatorType { get; set; }

        [JsonProperty("data")]
        [JsonPropertyName("data")]
        public IgItem Data { get; set; }

        [JsonProperty("localName")]
        [JsonPropertyName("localName")]
        public string LocalName { get; set; }
    }

    public class Thruster2
    {
        [JsonProperty("thrustCapacity")]
        [JsonPropertyName("thrustCapacity")]
        public double? ThrustCapacity { get; set; }

        [JsonProperty("minHealthThrustMultiplier")]
        [JsonPropertyName("minHealthThrustMultiplier")]
        public double? MinHealthThrustMultiplier { get; set; }

        [JsonProperty("fuelBurnRatePer10KNewton")]
        [JsonPropertyName("fuelBurnRatePer10KNewton")]
        public double? FuelBurnRatePer10KNewton { get; set; }

        [JsonProperty("thrusterType")]
        [JsonPropertyName("thrusterType")]
        public string ThrusterType { get; set; }

        [JsonProperty("onlyActiveInVTOL")]
        [JsonPropertyName("onlyActiveInVTOL")]
        public bool OnlyActiveInVTOL { get; set; }

        [JsonProperty("thrusterStrengthSmooth")]
        [JsonPropertyName("thrusterStrengthSmooth")]
        public int? ThrusterStrengthSmooth { get; set; }

        [JsonProperty("toggleThrusterBackwash")]
        [JsonPropertyName("toggleThrusterBackwash")]
        public int? ToggleThrusterBackwash { get; set; }

        [JsonProperty("automateBackwashSize")]
        [JsonPropertyName("automateBackwashSize")]
        public int? AutomateBackwashSize { get; set; }

        [JsonProperty("thrusterBackwashMaxSpeed")]
        [JsonPropertyName("thrusterBackwashMaxSpeed")]
        public int? ThrusterBackwashMaxSpeed { get; set; }

        [JsonProperty("thrusterBackwashMaxDensity")]
        [JsonPropertyName("thrusterBackwashMaxDensity")]
        public int? ThrusterBackwashMaxDensity { get; set; }

        [JsonProperty("thrusterBackwashMaxResistance")]
        [JsonPropertyName("thrusterBackwashMaxResistance")]
        public int? ThrusterBackwashMaxResistance { get; set; }

        [JsonProperty("thrusterBackwashAfterburnerMultiplier")]
        [JsonPropertyName("thrusterBackwashAfterburnerMultiplier")]
        public double? ThrusterBackwashAfterburnerMultiplier { get; set; }

        [JsonProperty("isFlex")]
        [JsonPropertyName("isFlex")]
        public bool IsFlex { get; set; }
    }

    public class Vehicle
    {
        [JsonProperty("vehicleDefinition")]
        [JsonPropertyName("vehicleDefinition")]
        public string VehicleDefinition { get; set; }

        [JsonProperty("modification")]
        [JsonPropertyName("modification")]
        public string Modification { get; set; }

        [JsonProperty("dogfightEnabled")]
        [JsonPropertyName("dogfightEnabled")]
        public bool DogfightEnabled { get; set; }

        [JsonProperty("crewSize")]
        [JsonPropertyName("crewSize")]
        public int? CrewSize { get; set; }

        [JsonProperty("career")]
        [JsonPropertyName("career")]
        public string Career { get; set; }

        [JsonProperty("role")]
        [JsonPropertyName("role")]
        public string Role { get; set; }

        [JsonProperty("size")]
        [JsonPropertyName("size")]
        public Size Size { get; set; } = new Size();

        [JsonProperty("inventory")]
        [JsonPropertyName("inventory")]
        public string Inventory { get; set; }

        [JsonProperty("inventoryCapacity")]
        [JsonPropertyName("inventoryCapacity")]
        public double? InventoryCapacity { get; set; }
        public int? MinCrew { get; internal set; }

    }

    public class WeaponRegenPoolCrew
    {
        [JsonProperty("regenFillRate")]
        [JsonPropertyName("regenFillRate")]
        public int? RegenFillRate { get; set; }

        [JsonProperty("ammoLoad")]
        [JsonPropertyName("ammoLoad")]
        public int? AmmoLoad { get; set; }

        [JsonProperty("respectsCapacitorAssignments")]
        [JsonPropertyName("respectsCapacitorAssignments")]
        public bool RespectsCapacitorAssignments { get; set; }
    }

    public class WeaponRegenPoolTurret
    {
        [JsonProperty("regenFillRate")]
        [JsonPropertyName("regenFillRate")]
        public int? RegenFillRate { get; set; }

        [JsonProperty("ammoLoad")]
        [JsonPropertyName("ammoLoad")]
        public int? AmmoLoad { get; set; }

        [JsonProperty("respectsCapacitorAssignments")]
        [JsonPropertyName("respectsCapacitorAssignments")]
        public bool RespectsCapacitorAssignments { get; set; }
    }


    public class Absorption
    {
        [JsonProperty("physicalMin")]
        [JsonPropertyName("physicalMin")]
        public int? PhysicalMin { get; set; }

        [JsonProperty("physicalMax")]
        [JsonPropertyName("physicalMax")]
        public double? PhysicalMax { get; set; }

        [JsonProperty("energyMin")]
        [JsonPropertyName("energyMin")]
        public int? EnergyMin { get; set; }

        [JsonProperty("energyMax")]
        [JsonPropertyName("energyMax")]
        public int? EnergyMax { get; set; }

        [JsonProperty("distortionMin")]
        [JsonPropertyName("distortionMin")]
        public int? DistortionMin { get; set; }

        [JsonProperty("distortionMax")]
        [JsonPropertyName("distortionMax")]
        public int? DistortionMax { get; set; }

        [JsonProperty("thermalMin")]
        [JsonPropertyName("thermalMin")]
        public int? ThermalMin { get; set; }

        [JsonProperty("thermalMax")]
        [JsonPropertyName("thermalMax")]
        public int? ThermalMax { get; set; }

        [JsonProperty("biochemicalMin")]
        [JsonPropertyName("biochemicalMin")]
        public int? BiochemicalMin { get; set; }

        [JsonProperty("biochemicalMax")]
        [JsonPropertyName("biochemicalMax")]
        public int? BiochemicalMax { get; set; }

        [JsonProperty("stunMin")]
        [JsonPropertyName("stunMin")]
        public int? StunMin { get; set; }

        [JsonProperty("stunMax")]
        [JsonPropertyName("stunMax")]
        public int? StunMax { get; set; }
    }

    public class Ammo
    {
        [JsonProperty("calculatorType")]
        [JsonPropertyName("calculatorType")]
        public string CalculatorType { get; set; }

        [JsonProperty("data")]
        [JsonPropertyName("data")]
        public IgItem Data { get; set; }

        [JsonProperty("localName")]
        [JsonPropertyName("localName")]
        public string LocalName { get; set; }
    }

    public class AmmoContainer
    {
        [JsonProperty("initialAmmoCount")]
        [JsonPropertyName("initialAmmoCount")]
        public int? InitialAmmoCount { get; set; }

        [JsonProperty("maxAmmoCount")]
        [JsonPropertyName("maxAmmoCount")]
        public long MaxAmmoCount { get; set; }

        [JsonProperty("ammoRef")]
        [JsonPropertyName("ammoRef")]
        public string AmmoRef { get; set; }
    }

    public class ChargeActions
    {
        [JsonProperty("chargeTime")]
        [JsonPropertyName("chargeTime")]
        public double? ChargeTime { get; set; }

        [JsonProperty("overchargeTime")]
        [JsonPropertyName("overchargeTime")]
        public int? OverchargeTime { get; set; }

        [JsonProperty("overchargedTime")]
        [JsonPropertyName("overchargedTime")]
        public int? OverchargedTime { get; set; }

        [JsonProperty("cooldownTime")]
        [JsonPropertyName("cooldownTime")]
        public double? CooldownTime { get; set; }

        [JsonProperty("maxGlow")]
        [JsonPropertyName("maxGlow")]
        public int? MaxGlow { get; set; }

        [JsonProperty("fireAutomaticallyOnFullCharge")]
        [JsonPropertyName("fireAutomaticallyOnFullCharge")]
        public bool FireAutomaticallyOnFullCharge { get; set; }

        [JsonProperty("fireOnlyOnFullCharge")]
        [JsonPropertyName("fireOnlyOnFullCharge")]
        public bool FireOnlyOnFullCharge { get; set; }
    }

    public class Connection
    {
        [JsonProperty("powerActiveCooldown")]
        [JsonPropertyName("powerActiveCooldown")]
        public double? PowerActiveCooldown { get; set; }

        [JsonProperty("heatRateOnline")]
        [JsonPropertyName("heatRateOnline")]
        public double? HeatRateOnline { get; set; }

        [JsonProperty("maxGlow")]
        [JsonPropertyName("maxGlow")]
        public int? MaxGlow { get; set; }

        [JsonProperty("noPowerStats")]
        [JsonPropertyName("noPowerStats")]
        public NoPowerStats NoPowerStats { get; set; }

        [JsonProperty("underpowerStats")]
        [JsonPropertyName("underpowerStats")]
        public UnderpowerStats UnderpowerStats { get; set; }

        [JsonProperty("overpowerStats")]
        [JsonPropertyName("overpowerStats")]
        public OverpowerStats OverpowerStats { get; set; }

        [JsonProperty("overclockStats")]
        [JsonPropertyName("overclockStats")]
        public OverclockStats OverclockStats { get; set; }

        [JsonProperty("heatStats")]
        [JsonPropertyName("heatStats")]
        public HeatStats HeatStats { get; set; }
    }

    public class Damage
    {
        [JsonProperty("alphaMax")]
        [JsonPropertyName("alphaMax")]
        public double? AlphaMax { get; set; }

        [JsonProperty("alphaMin")]
        [JsonPropertyName("alphaMin")]
        public double? AlphaMin { get; set; }

        [JsonProperty("fireRateMax")]
        [JsonPropertyName("fireRateMax")]
        public double? FireRateMax { get; set; }

        [JsonProperty("fireRateMin")]
        [JsonPropertyName("fireRateMin")]
        public double? FireRateMin { get; set; }

        [JsonProperty("damagePhysical")]
        [JsonPropertyName("damagePhysical")]
        public double? DamagePhysical { get; set; }

        [JsonProperty("damageEnergy")]
        [JsonPropertyName("damageEnergy")]
        public double? DamageEnergy { get; set; }

        [JsonProperty("damageDistortion")]
        [JsonPropertyName("damageDistortion")]
        public int? DamageDistortion { get; set; }

        [JsonProperty("damageThermal")]
        [JsonPropertyName("damageThermal")]
        public int? DamageThermal { get; set; }

        [JsonProperty("damageBiochemical")]
        [JsonPropertyName("damageBiochemical")]
        public int? DamageBiochemical { get; set; }

        [JsonProperty("damageStun")]
        [JsonPropertyName("damageStun")]
        public int? DamageStun { get; set; }
    }

    public class Explosion
    {
        [JsonProperty("armTime")]
        [JsonPropertyName("armTime")]
        public int? ArmTime { get; set; }

        [JsonProperty("safeDistance")]
        [JsonPropertyName("safeDistance")]
        public int? SafeDistance { get; set; }

        [JsonProperty("destructDelay")]
        [JsonPropertyName("destructDelay")]
        public int? DestructDelay { get; set; }

        [JsonProperty("explodeOnImpact")]
        [JsonPropertyName("explodeOnImpact")]
        public bool ExplodeOnImpact { get; set; }

        [JsonProperty("explodeOnFinalImpact")]
        [JsonPropertyName("explodeOnFinalImpact")]
        public bool ExplodeOnFinalImpact { get; set; }

        [JsonProperty("explodeOnExpire")]
        [JsonPropertyName("explodeOnExpire")]
        public bool ExplodeOnExpire { get; set; }

        [JsonProperty("explodeOnTargetRange")]
        [JsonPropertyName("explodeOnTargetRange")]
        public bool ExplodeOnTargetRange { get; set; }

        [JsonProperty("minRadius")]
        [JsonPropertyName("minRadius")]
        public double? MinRadius { get; set; }

        [JsonProperty("maxRadius")]
        [JsonPropertyName("maxRadius")]
        public int? MaxRadius { get; set; }

        [JsonProperty("minPhysRadius")]
        [JsonPropertyName("minPhysRadius")]
        public double? MinPhysRadius { get; set; }

        [JsonProperty("maxPhysRadius")]
        [JsonPropertyName("maxPhysRadius")]
        public int? MaxPhysRadius { get; set; }

        [JsonProperty("pressure")]
        [JsonPropertyName("pressure")]
        public int? Pressure { get; set; }

        [JsonProperty("holeSize")]
        [JsonPropertyName("holeSize")]
        public int? HoleSize { get; set; }

        [JsonProperty("hitType")]
        [JsonPropertyName("hitType")]
        public string HitType { get; set; }

        [JsonProperty("damage")]
        [JsonPropertyName("damage")]
        public Damage Damage { get; set; }
    }

    public class FireActions
    {
        [JsonProperty("delay")]
        [JsonPropertyName("delay")]
        public int? Delay { get; set; }

        [JsonProperty("fireRate")]
        [JsonPropertyName("fireRate")]
        public int? FireRate { get; set; }

        [JsonProperty("heatPerShot")]
        [JsonPropertyName("heatPerShot")]
        public int? HeatPerShot { get; set; }

        [JsonProperty("ammoCost")]
        [JsonPropertyName("ammoCost")]
        public int? AmmoCost { get; set; }

        [JsonProperty("pelletCount")]
        [JsonPropertyName("pelletCount")]
        public int? PelletCount { get; set; }

        [JsonProperty("damageMultiplier")]
        [JsonPropertyName("damageMultiplier")]
        public int? DamageMultiplier { get; set; }

        [JsonProperty("maxChargeDamageMultiplier")]
        [JsonPropertyName("maxChargeDamageMultiplier")]
        public double? MaxChargeDamageMultiplier { get; set; }

        [JsonProperty("spinUpTime")]
        [JsonPropertyName("spinUpTime")]
        public double? SpinUpTime { get; set; }

        [JsonProperty("spinDownTime")]
        [JsonPropertyName("spinDownTime")]
        public double? SpinDownTime { get; set; }
    }



    public class HeatStats
    {
        [JsonProperty("fireRate")]
        [JsonPropertyName("fireRate")]
        public int? FireRate { get; set; }

        [JsonProperty("fireRateMultiplier")]
        [JsonPropertyName("fireRateMultiplier")]
        public int? FireRateMultiplier { get; set; }

        [JsonProperty("damageMultiplier")]
        [JsonPropertyName("damageMultiplier")]
        public int? DamageMultiplier { get; set; }

        [JsonProperty("projectileSpeedMultiplier")]
        [JsonPropertyName("projectileSpeedMultiplier")]
        public int? ProjectileSpeedMultiplier { get; set; }

        [JsonProperty("pellets")]
        [JsonPropertyName("pellets")]
        public int? Pellets { get; set; }

        [JsonProperty("burstShots")]
        [JsonPropertyName("burstShots")]
        public int? BurstShots { get; set; }

        [JsonProperty("ammoCost")]
        [JsonPropertyName("ammoCost")]
        public int? AmmoCost { get; set; }

        [JsonProperty("ammoCostMultiplier")]
        [JsonPropertyName("ammoCostMultiplier")]
        public int? AmmoCostMultiplier { get; set; }

        [JsonProperty("heatGenerationMultiplier")]
        [JsonPropertyName("heatGenerationMultiplier")]
        public int? HeatGenerationMultiplier { get; set; }

        [JsonProperty("spreadModifier")]
        [JsonPropertyName("spreadModifier")]
        public SpreadModifier SpreadModifier { get; set; }
    }

    public class Inventory
    {
        [JsonProperty("localName")]
        [JsonPropertyName("localName")]
        public string LocalName { get; set; }

        [JsonProperty("basePrice")]
        [JsonPropertyName("basePrice")]
        public int? BasePrice { get; set; }

        [JsonProperty("price")]
        [JsonPropertyName("price")]
        public int? Price { get; set; }

        [JsonProperty("ref")]
        [JsonPropertyName("ref")]
        public string Ref { get; set; }
    }



    public class MiningModifier
    {
        [JsonProperty("resistanceModifier")]
        [JsonPropertyName("resistanceModifier")]
        public int? ResistanceModifier { get; set; }

        [JsonProperty("laserInstability")]
        [JsonPropertyName("laserInstability")]
        public int? LaserInstability { get; set; }

        [JsonProperty("optimalChargeWindowSizeModifier")]
        [JsonPropertyName("optimalChargeWindowSizeModifier")]
        public int? OptimalChargeWindowSizeModifier { get; set; }

        [JsonProperty("shatterdamageModifier")]
        [JsonPropertyName("shatterdamageModifier")]
        public int? ShatterdamageModifier { get; set; }

        [JsonProperty("optimalChargeWindowRateModifier")]
        [JsonPropertyName("optimalChargeWindowRateModifier")]
        public int? OptimalChargeWindowRateModifier { get; set; }

        [JsonProperty("catastrophicChargeWindowRateModifier")]
        [JsonPropertyName("catastrophicChargeWindowRateModifier")]
        public int? CatastrophicChargeWindowRateModifier { get; set; }
    }

    public class Modifier
    {
        [JsonProperty("charges")]
        [JsonPropertyName("charges")]
        public int? Charges { get; set; }

        [JsonProperty("canInterrupt")]
        [JsonPropertyName("canInterrupt")]
        public bool CanInterrupt { get; set; }

        [JsonProperty("isInterruptible")]
        [JsonPropertyName("isInterruptible")]
        public bool IsInterruptible { get; set; }

        [JsonProperty("weaponModifier")]
        [JsonPropertyName("weaponModifier")]
        public WeaponModifier WeaponModifier { get; set; }

        [JsonProperty("miningModifier")]
        [JsonPropertyName("miningModifier")]
        public MiningModifier MiningModifier { get; set; }
    }

    public class NoPowerStats
    {
        [JsonProperty("fireRate")]
        [JsonPropertyName("fireRate")]
        public int? FireRate { get; set; }

        [JsonProperty("fireRateMultiplier")]
        [JsonPropertyName("fireRateMultiplier")]
        public int? FireRateMultiplier { get; set; }

        [JsonProperty("damageMultiplier")]
        [JsonPropertyName("damageMultiplier")]
        public int? DamageMultiplier { get; set; }

        [JsonProperty("projectileSpeedMultiplier")]
        [JsonPropertyName("projectileSpeedMultiplier")]
        public int? ProjectileSpeedMultiplier { get; set; }

        [JsonProperty("pellets")]
        [JsonPropertyName("pellets")]
        public int? Pellets { get; set; }

        [JsonProperty("burstShots")]
        [JsonPropertyName("burstShots")]
        public int? BurstShots { get; set; }

        [JsonProperty("ammoCost")]
        [JsonPropertyName("ammoCost")]
        public int? AmmoCost { get; set; }

        [JsonProperty("ammoCostMultiplier")]
        [JsonPropertyName("ammoCostMultiplier")]
        public int? AmmoCostMultiplier { get; set; }

        [JsonProperty("heatGenerationMultiplier")]
        [JsonPropertyName("heatGenerationMultiplier")]
        public int? HeatGenerationMultiplier { get; set; }

        [JsonProperty("spreadModifier")]
        [JsonPropertyName("spreadModifier")]
        public SpreadModifier SpreadModifier { get; set; }
    }

    public class OverclockStats
    {
        [JsonProperty("fireRate")]
        [JsonPropertyName("fireRate")]
        public int? FireRate { get; set; }

        [JsonProperty("fireRateMultiplier")]
        [JsonPropertyName("fireRateMultiplier")]
        public double? FireRateMultiplier { get; set; }

        [JsonProperty("damageMultiplier")]
        [JsonPropertyName("damageMultiplier")]
        public int? DamageMultiplier { get; set; }

        [JsonProperty("projectileSpeedMultiplier")]
        [JsonPropertyName("projectileSpeedMultiplier")]
        public int? ProjectileSpeedMultiplier { get; set; }

        [JsonProperty("pellets")]
        [JsonPropertyName("pellets")]
        public int? Pellets { get; set; }

        [JsonProperty("burstShots")]
        [JsonPropertyName("burstShots")]
        public int? BurstShots { get; set; }

        [JsonProperty("ammoCost")]
        [JsonPropertyName("ammoCost")]
        public int? AmmoCost { get; set; }

        [JsonProperty("ammoCostMultiplier")]
        [JsonPropertyName("ammoCostMultiplier")]
        public int? AmmoCostMultiplier { get; set; }

        [JsonProperty("heatGenerationMultiplier")]
        [JsonPropertyName("heatGenerationMultiplier")]
        public int? HeatGenerationMultiplier { get; set; }

        [JsonProperty("spreadModifier")]
        [JsonPropertyName("spreadModifier")]
        public SpreadModifier SpreadModifier { get; set; }
    }

    public class OverpowerStats
    {
        [JsonProperty("fireRate")]
        [JsonPropertyName("fireRate")]
        public int? FireRate { get; set; }

        [JsonProperty("fireRateMultiplier")]
        [JsonPropertyName("fireRateMultiplier")]
        public double? FireRateMultiplier { get; set; }

        [JsonProperty("damageMultiplier")]
        [JsonPropertyName("damageMultiplier")]
        public int? DamageMultiplier { get; set; }

        [JsonProperty("projectileSpeedMultiplier")]
        [JsonPropertyName("projectileSpeedMultiplier")]
        public int? ProjectileSpeedMultiplier { get; set; }

        [JsonProperty("pellets")]
        [JsonPropertyName("pellets")]
        public int? Pellets { get; set; }

        [JsonProperty("burstShots")]
        [JsonPropertyName("burstShots")]
        public int? BurstShots { get; set; }

        [JsonProperty("ammoCost")]
        [JsonPropertyName("ammoCost")]
        public int? AmmoCost { get; set; }

        [JsonProperty("ammoCostMultiplier")]
        [JsonPropertyName("ammoCostMultiplier")]
        public int? AmmoCostMultiplier { get; set; }

        [JsonProperty("heatGenerationMultiplier")]
        [JsonPropertyName("heatGenerationMultiplier")]
        public int? HeatGenerationMultiplier { get; set; }

        [JsonProperty("spreadModifier")]
        [JsonPropertyName("spreadModifier")]
        public SpreadModifier SpreadModifier { get; set; }
    }

    public class Pierceability
    {
        [JsonProperty("damageFalloffLevel1")]
        [JsonPropertyName("damageFalloffLevel1")]
        public int? DamageFalloffLevel1 { get; set; }

        [JsonProperty("damageFalloffLevel2")]
        [JsonPropertyName("damageFalloffLevel2")]
        public int? DamageFalloffLevel2 { get; set; }

        [JsonProperty("damageFalloffLevel3")]
        [JsonPropertyName("damageFalloffLevel3")]
        public int? DamageFalloffLevel3 { get; set; }

        [JsonProperty("maxPenetrationThickness")]
        [JsonPropertyName("maxPenetrationThickness")]
        public double? MaxPenetrationThickness { get; set; }
    }


    public class Projectile
    {
        [JsonProperty("impactRadius")]
        [JsonPropertyName("impactRadius")]
        public int? ImpactRadius { get; set; }

        [JsonProperty("minImpactRadius")]
        [JsonPropertyName("minImpactRadius")]
        public double? MinImpactRadius { get; set; }

        [JsonProperty("hitType")]
        [JsonPropertyName("hitType")]
        public string HitType { get; set; }
    }

    public class Regen
    {
        [JsonProperty("requestedRegenPerSec")]
        [JsonPropertyName("requestedRegenPerSec")]
        public double? RequestedRegenPerSec { get; set; }

        [JsonProperty("regenerationCooldown")]
        [JsonPropertyName("regenerationCooldown")]
        public double? RegenerationCooldown { get; set; }

        [JsonProperty("regenerationCostPerBullet")]
        [JsonPropertyName("regenerationCostPerBullet")]
        public int? RegenerationCostPerBullet { get; set; }

        [JsonProperty("requestedAmmoLoad")]
        [JsonPropertyName("requestedAmmoLoad")]
        public int? RequestedAmmoLoad { get; set; }
    }

    public class Resistance
    {
        [JsonProperty("physicalMin")]
        [JsonPropertyName("physicalMin")]
        public int? PhysicalMin { get; set; }

        [JsonProperty("physicalMax")]
        [JsonPropertyName("physicalMax")]
        public double? PhysicalMax { get; set; }

        [JsonProperty("energyMin")]
        [JsonPropertyName("energyMin")]
        public int? EnergyMin { get; set; }

        [JsonProperty("energyMax")]
        [JsonPropertyName("energyMax")]
        public double? EnergyMax { get; set; }

        [JsonProperty("distortionMin")]
        [JsonPropertyName("distortionMin")]
        public int? DistortionMin { get; set; }

        [JsonProperty("distortionMax")]
        [JsonPropertyName("distortionMax")]
        public double? DistortionMax { get; set; }

        [JsonProperty("thermalMin")]
        [JsonPropertyName("thermalMin")]
        public int? ThermalMin { get; set; }

        [JsonProperty("thermalMax")]
        [JsonPropertyName("thermalMax")]
        public int? ThermalMax { get; set; }

        [JsonProperty("biochemicalMin")]
        [JsonPropertyName("biochemicalMin")]
        public int? BiochemicalMin { get; set; }

        [JsonProperty("biochemicalMax")]
        [JsonPropertyName("biochemicalMax")]
        public int? BiochemicalMax { get; set; }

        [JsonProperty("stunMin")]
        [JsonPropertyName("stunMin")]
        public int? StunMin { get; set; }

        [JsonProperty("stunMax")]
        [JsonPropertyName("stunMax")]
        public int? StunMax { get; set; }
    }

    public class Spread
    {
        [JsonProperty("min")]
        [JsonPropertyName("min")]
        public double? Min { get; set; }

        [JsonProperty("max")]
        [JsonPropertyName("max")]
        public double? Max { get; set; }

        [JsonProperty("firstAttack")]
        [JsonPropertyName("firstAttack")]
        public double? FirstAttack { get; set; }

        [JsonProperty("attack")]
        [JsonPropertyName("attack")]
        public double? Attack { get; set; }

        [JsonProperty("decay")]
        [JsonPropertyName("decay")]
        public double? Decay { get; set; }
    }

    public class SpreadModifier
    {
        [JsonProperty("minMultiplier")]
        [JsonPropertyName("minMultiplier")]
        public int? MinMultiplier { get; set; }

        [JsonProperty("maxMultiplier")]
        [JsonPropertyName("maxMultiplier")]
        public int? MaxMultiplier { get; set; }

        [JsonProperty("firstAttackMultiplier")]
        [JsonPropertyName("firstAttackMultiplier")]
        public int? FirstAttackMultiplier { get; set; }

        [JsonProperty("attackMultiplier")]
        [JsonPropertyName("attackMultiplier")]
        public int? AttackMultiplier { get; set; }

        [JsonProperty("decayMultiplier")]
        [JsonPropertyName("decayMultiplier")]
        public int? DecayMultiplier { get; set; }

        [JsonProperty("additiveModifier")]
        [JsonPropertyName("additiveModifier")]
        public int? AdditiveModifier { get; set; }
    }

    public class UnderpowerStats
    {
        [JsonProperty("fireRate")]
        [JsonPropertyName("fireRate")]
        public int? FireRate { get; set; }

        [JsonProperty("fireRateMultiplier")]
        [JsonPropertyName("fireRateMultiplier")]
        public double? FireRateMultiplier { get; set; }

        [JsonProperty("damageMultiplier")]
        [JsonPropertyName("damageMultiplier")]
        public int? DamageMultiplier { get; set; }

        [JsonProperty("projectileSpeedMultiplier")]
        [JsonPropertyName("projectileSpeedMultiplier")]
        public int? ProjectileSpeedMultiplier { get; set; }

        [JsonProperty("pellets")]
        [JsonPropertyName("pellets")]
        public int? Pellets { get; set; }

        [JsonProperty("burstShots")]
        [JsonPropertyName("burstShots")]
        public int? BurstShots { get; set; }

        [JsonProperty("ammoCost")]
        [JsonPropertyName("ammoCost")]
        public int? AmmoCost { get; set; }

        [JsonProperty("ammoCostMultiplier")]
        [JsonPropertyName("ammoCostMultiplier")]
        public int? AmmoCostMultiplier { get; set; }

        [JsonProperty("heatGenerationMultiplier")]
        [JsonPropertyName("heatGenerationMultiplier")]
        public int? HeatGenerationMultiplier { get; set; }

        [JsonProperty("spreadModifier")]
        [JsonPropertyName("spreadModifier")]
        public SpreadModifier SpreadModifier { get; set; }
    }

    public class Weapon
    {
        [JsonProperty("supplementaryFireTime")]
        [JsonPropertyName("supplementaryFireTime")]
        public double? SupplementaryFireTime { get; set; }

        [JsonProperty("idealCombatRange")]
        [JsonPropertyName("idealCombatRange")]
        public int? IdealCombatRange { get; set; }

        [JsonProperty("connection")]
        [JsonPropertyName("connection")]
        public Connection Connection { get; set; }

        [JsonProperty("regen")]
        [JsonPropertyName("regen")]
        public Regen Regen { get; set; }

        [JsonProperty("fireActions")]
        [JsonPropertyName("fireActions")]
        public FireActions FireActions { get; set; }

        [JsonProperty("spread")]
        [JsonPropertyName("spread")]
        public Spread Spread { get; set; }

        [JsonProperty("damage")]
        [JsonPropertyName("damage")]
        public Damage Damage { get; set; }

        [JsonProperty("chargeActions")]
        [JsonPropertyName("chargeActions")]
        public ChargeActions ChargeActions { get; set; }
    }

    public class WeaponModifier
    {
        [JsonProperty("laserDamageMultiplier")]
        [JsonPropertyName("laserDamageMultiplier")]
        public int? LaserDamageMultiplier { get; set; }
    }

}