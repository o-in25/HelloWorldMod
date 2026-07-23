import { ModRegistrar } from "cs2/modding";
import { HelloWorldComponent } from "mods/hello-world";
import { DayNightToggleComponent } from "mods/DayNightToggleComponent/DayNightToggleComponent";

const register: ModRegistrar = (moduleRegistry) => {

    moduleRegistry.append('Menu', HelloWorldComponent);
    moduleRegistry.append('UniversalModMenu', DayNightToggleComponent);
}

export default register;