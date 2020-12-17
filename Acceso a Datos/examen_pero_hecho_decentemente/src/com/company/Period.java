package com.company;

public enum Period {
    CRETACEOUS("145", "66"),
    JURASSIC("201", "145"),
    CRETACEOUS_TRIASSIC("251", "201");

    private final String periodStart;
    private final String periodEnd;

    private Period(String periodStart, String periodEnd) {
        this.periodStart = periodStart;
        this.periodEnd = periodEnd;
    }

    public String getPeriodEnd() {
        return periodEnd;
    }
    public String getPeriodStart() {
        return periodStart;
    }
}
