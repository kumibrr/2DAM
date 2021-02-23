package com.company.model;

public enum Position {
    TOP("TOP"),
    JUNGLE("JUNGLE"),
    MIDLANE("MIDLANE"),
    ADCARRY("ADCARRY"),
    SUPPORT("SUPPORT");

    private final String str;

    Position(String str) {
        this.str = str;
    }

    public String getStr() {
        return str;
    }

    public static Position getPosition(String position) {
        Position r = TOP;
        switch (position){
            case "JUNGLE":
                r = JUNGLE;
                break;
            case "MIDLANE":
                r = MIDLANE;
                break;
            case "ADCARRY":
                r = ADCARRY;
                break;
            case "SUPPORT":
                r = SUPPORT;
                break;
        }
        return r;
    }
}
