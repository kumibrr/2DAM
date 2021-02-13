export interface Incident {
    id: number;
    title: string;
    hasBeenSolved: boolean;
    description: string;
    dateSubmitted: Date;
    dateSolved: Date;
    level: number;
}
