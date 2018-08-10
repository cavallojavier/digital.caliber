export class measuresResult {
    public id: number;
    public hcNumber: string;
    public patientName: string;
    public date: Date;

    public dentalBoneDiscrepancy: dentalBoneDiscrepancy;
    public tanaka: tanakaJohnston;
    public pont: pont;
    public moyers: moyers;
    public boltonTotal: boltonTotal;
    public boltonPreviousRelation: boltonPreviousRelation

    constructor() {
        this.id = 0;
        this.hcNumber = '';
        this.patientName = '';
        this.dentalBoneDiscrepancy = new dentalBoneDiscrepancy;
        this.tanaka = new tanakaJohnston;
        this.pont = new pont;
        this.moyers = new moyers;
        this.boltonTotal = new boltonTotal;
        this.boltonPreviousRelation = new boltonPreviousRelation;
    }
}

class dentalBoneDiscrepancy{
    public superior: number|null;
    public inferior: number|null;
    public superiorAntero: number|null;
    public inferiorAntero: number|null;
    public inferiorIncisives: number|null;
}

class tanakaJohnston{
    public superior: number|null;
    public inferior: number|null;
}

class pont{
    public pont14To24: number|null;
    public pont16To26: number|null;
    public archLong: number|null;
}

class moyers{
    public leftSuperior: number|null;
    public leftInferior: number|null;
    public rightSuperior: number|null;
    public rightInferior: number|null;
}

class boltonTotal{
    public maxilar12Pac: number|null;
    public mandibular12Pac: number|null;
    public mandibular12Ideal: number|null;
    public maxilar12Ideal: number|null;

    public inferiorExcess: number|null;
    public superiorExcess: number|null;
    public total: number|null;
    public isSuperiorExcess: number|null;
}

class boltonPreviousRelation{
    public maxilar6Pac: number|null;
    public mandibular6Pac: number|null;
    public mandibular6Ideal: number|null;
    public maxilar6Ideal: number|null;

    public inferiorExcess: number|null;
    public superiorExcess: number|null;
    public total: number|null;
    public isSuperiorExcess: number|null;
}