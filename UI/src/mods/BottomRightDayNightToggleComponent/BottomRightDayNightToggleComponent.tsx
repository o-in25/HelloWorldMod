import { Button } from "cs2/ui";
import { bindValue, trigger, useValue } from "cs2/api";
import { getModule } from "cs2/modding";
import classNames from "classnames";
import mod from "../../../mod.json";

const DayNightVisual$ = bindValue<boolean>(mod.id, "DayNightVisual", true);

// Pulls the vanilla game's own CSS module classes for the bottom-right toolbar
// row, so this button is styled identically to native toggles (topography,
// underground view, etc.) rather than approximating their look by hand.
const rightMenuStyles = getModule("game-ui/game/components/right-menu/right-menu.module.scss", "classes");
const rightMenuButtonStyles = getModule("game-ui/game/components/right-menu/right-menu-button.module.scss", "classes");

export const BottomRightDayNightToggleComponent = () => {
    const dayNightVisual = useValue(DayNightVisual$);

    return (
        <div className={rightMenuStyles.item}>
            <Button
                src="Media/Game/Misc/ScheduleDayNight.svg"
                variant="icon"
                className={classNames(dayNightVisual ? "selected" : "", rightMenuButtonStyles.button)}
                onSelect={() => trigger(mod.id, "ToggleDayNightVisual")}
                tooltipLabel="Day/Night Cycle"
            />
        </div>
    );
}
