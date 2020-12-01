export class BlogEntry {
    title: string;
    body: string;
    date: Date;
    constructor(title: string, body: string) {
        this.title = title;
        this.body = body;
        this.date = new Date();
    }
}