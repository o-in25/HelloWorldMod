import { Button } from "cs2/ui";
import { bindValue, trigger, useValue } from "cs2/api";
import classNames from "classnames";
import mod from "../../../mod.json";
import styles from "./dayNightToggleStyles.module.scss";

const DayNightVisual$ = bindValue<boolean>(mod.id, "DayNightVisual", true);

export const DayNightToggleComponent = () => {
    const dayNightVisual = useValue(DayNightVisual$);

    return (
        <Button
            src="Media/Game/Misc/ScheduleDayNight.svg"
            variant="floating"
            selected={dayNightVisual}
            className={classNames(styles.overrideBackGroundColor, { [styles.disabled]: !dayNightVisual })}
            onSelect={() => trigger(mod.id, "ToggleDayNightVisual")}
            tooltipLabel="Day/Night Cycle"
        />
    );
}
