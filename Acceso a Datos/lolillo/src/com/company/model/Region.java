package com.company.model;

public enum Region {
    EU("EU"), NA("NA"), SA("SA"), KR("KR"), CN("CN"), AP("AP");

    private final String str;

    Region(String str) {
        this.str = str;
    }

    public String getStr() {
        return str;
    }

    public static Region getRegion(String region) {
        Region r = EU;
        switch (region){
            case "NA":
                r = NA;
                break;
            case "SA":
                r = SA;
                break;
            case "KR":
                r = KR;
                break;
            case "CN":
                r = CN;
                break;
            case "AP":
                r = AP;
                break;
        }
        return r;
    }
}
