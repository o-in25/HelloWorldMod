import { ModRegistrar } from "cs2/modding";
import { HelloWorldComponent } from "mods/hello-world";
import { DayNightToggleComponent } from "mods/DayNightToggleComponent/DayNightToggleComponent";
import { BottomRightDayNightToggleComponent } from "mods/BottomRightDayNightToggleComponent/BottomRightDayNightToggleComponent";

const register: ModRegistrar = (moduleRegistry) => {

    moduleRegistry.append('Menu', HelloWorldComponent);
    moduleRegistry.append('UniversalModMenu', DayNightToggleComponent);
    moduleRegistry.append('GameBottomRight', BottomRightDayNightToggleComponent);
}

export default register;