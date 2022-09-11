using LLCharReplace.Properties;
using System.Linq;

namespace LLCharReplace;

public partial class Form1 : Form
{
    bool canwork = false;
    int tabActiveIdx = 0;
    Dictionary<string, string> charNames = new()
    {
        { "c01", "¦Ì's-Honoka Kosaka" },
        { "c02", "¦Ì's-Eli Ayase" },
        { "c03", "¦Ì's-Kotori Minami" },
        { "c04", "¦Ì's-Umi Sonoda" },
        { "c05", "¦Ì's-Rin Hoshizora" },
        { "c06", "¦Ì's-Maki Nishikino" },
        { "c07", "¦Ì's-Nozomi Tojo" },
        { "c08", "¦Ì's-Hanayo Koizumi" },
        { "c09", "¦Ì's-Nico Yazawa" },
        { "c11", "Aqours-Chika Takami" },
        { "c12", "Aqours-Riko Sakurauchi" },
        { "c13", "Aqours-Kanan Matsuura" },
        { "c14", "Aqours-Dia Kurosawa" },
        { "c15", "Aqours-You Watanabe" },
        { "c16", "Aqours-Yoshiko Tsushima" },
        { "c17", "Aqours-Hanamaru Kunikida" },
        { "c18", "Aqours-Mari Ohara" },
        { "c19", "Aqours-Ruby Kurosawa" },
        { "c21", "Saint Snow-Sarah Kazuno" },
        { "c22", "Saint Snow-Leah Kazuno" }
    };
    Dictionary<string, IList<string>> charGroups = new()
    {
        { "¦Ì's", new[] { "c01", "c02", "c03", "c04", "c05", "c06", "c07", "c08", "c09" } },
        { "Aqours", new[] { "c11", "c12", "c13", "c14", "c15", "c16", "c17", "c18", "c19" } },
        { "Saint Snow", new[] { "c21", "c22" } }
    };
    public Form1()
    {
        InitializeComponent();
        ddl_char.DisplayMember = "label";
        ddl_char.ValueMember = "value";
        ddl_charTarget.DisplayMember = "label";
        ddl_charTarget.DisplayMember = "value";
        ddl_charReplace.DisplayMember = "label";
        ddl_charReplace.DisplayMember = "value";
        ddl_target_group.DisplayMember = "label";
        ddl_target_group.DisplayMember = "value";
        ddl_replace_group.DisplayMember = "label";
        ddl_replace_group.DisplayMember = "value";
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(Settings.Default.gamefolder))
        {
            input_gamefolder.Text = Settings.Default.gamefolder;
            IsSIFACFolder(Settings.Default.gamefolder);
        }
        ddl_group.SelectedIndex = 0;
    }

    private void input_gamefolder_TextChanged(object sender, EventArgs e)
    {
        Settings.Default.gamefolder = input_gamefolder.Text.Trim();
        if (IsSIFACFolder(Settings.Default.gamefolder))
        {
            Settings.Default.Save();
        }
        else
        {
            MessageBox.Show("this folder is not sifac");
        }
    }

    private void btn_choosegamefolder_Click(object sender, EventArgs e)
    {
        var folderdialog = new FolderBrowserDialog();
        folderdialog.Description = "choose sifac folder";
        if (folderdialog.ShowDialog() == DialogResult.OK)
        {
            if (IsSIFACFolder(folderdialog.SelectedPath))
            {
                Settings.Default.gamefolder = folderdialog.SelectedPath;
                Settings.Default.Save();
                input_gamefolder.Text = Settings.Default.gamefolder;
            }
            else
            {
                MessageBox.Show("this folder is not sifac");
            }
        }
    }
    void BakFile(string filepath)
    {
        if (!File.Exists(filepath))
        {
            return;
        }
        var filep_bak = $"{filepath}.bak";
        if (!File.Exists(filep_bak))
        {
            File.Copy(filepath, filep_bak);
        }
    }
    bool IsSIFACFolder(string path)
    {
        if (string.IsNullOrWhiteSpace(path))
        {
            canwork = false;
            return false;
        }
        canwork = File.Exists($"{path}/ll3.exe");
        return canwork;
    }
    bool RestoreFile(string filepath)
    {
        if (!File.Exists(filepath))
        {
            return false;
        }
        var filep_bak = $"{filepath}.bak";
        if (File.Exists(filep_bak))
        {
            File.Copy(filep_bak, filepath, true);
            return true;
        }
        return false;
    }
    #region tab-solo
    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
        tabActiveIdx = tabControl1.SelectedIndex;
    }

    private void btnLoadCharList_Click(object sender, EventArgs e)
    {
        if (!canwork)
        {
            MessageBox.Show("pls choose game folder");
            return;
        }
        var dir_char = Path.Combine(input_gamefolder.Text, "chr");
        if (!Directory.Exists(dir_char))
        {
            MessageBox.Show("no such path \"chr\"");
            return;
        }
        var dirs = Directory.GetDirectories(dir_char, "c*");
        ddl_char.DataBindings.Clear();
        var listdata = new List<ListMember>();
        foreach (var dir in dirs)
        {
            var dir_name = dir.Substring(dir.LastIndexOf("\\") + 1);
            charNames.TryGetValue(dir_name, out var label);
            listdata.Add(new ListMember
            {
                value = dir_name,
                label = label ?? dir_name
            });
        }
        ddl_char.DataSource = listdata;
        ddl_char.SelectedIndex = 0;
    }

    private void ddl_char_SelectedIndexChanged(object sender, EventArgs e)
    {
        var chooseChar = ddl_char.SelectedItem as ListMember;
        var dir_char_cloth = Path.Combine(input_gamefolder.Text, "chr", chooseChar.value);
        var dirs = Directory.GetDirectories(dir_char_cloth);
        ddl_charTarget.DataBindings.Clear();
        ddl_charReplace.DataBindings.Clear();
        var listdata = new List<ListMember>();
        foreach (var dir in dirs)
        {
            var dir_name = dir.Substring(dir.LastIndexOf("\\") + 1);
            listdata.Add(new ListMember
            {
                label = dir_name,
                value = dir_name
            });
        }
        ddl_charTarget.DataSource = listdata;
        var listdata_new = listdata.ToList();
        listdata_new.Add(new ListMember { label = "basebody", value = $"{chooseChar.value}.pac" });
        ddl_charReplace.DataSource = listdata_new.ToArray();
        ddl_charReplace.SelectedIndex = 0;
        if (chooseChar.label.Contains("¦Ì's"))
        {
            var item = listdata.FirstOrDefault(d => d.label == "d001");
            if (item != null)
            {
                ddl_charTarget.SelectedItem = item;
            }
            else
            {
                ddl_charTarget.SelectedIndex = 0;
            }
        }
        else if (chooseChar.label.Contains("Aqours"))
        {
            var item = listdata.FirstOrDefault(d => d.label == "d090");
            if (item != null)
            {
                ddl_charTarget.SelectedItem = item;
            }
            else
            {
                ddl_charTarget.SelectedIndex = 0;
            }
        }
        else
        {
            var item = listdata.FirstOrDefault(d => d.label == "d200");
            if (item != null)
            {
                ddl_charTarget.SelectedItem = item;
            }
            else
            {
                ddl_charTarget.SelectedIndex = 0;
            }
        }
    }

    private void btnGo_Click(object sender, EventArgs e)
    {
        if (ddl_char.SelectedIndex == -1)
        {
            MessageBox.Show("pls choose char");
            return;
        }
        var chooseChar = ddl_char.SelectedItem as ListMember;
        var chooseTarget = ddl_charTarget.SelectedItem as ListMember;
        var chooseReplace = ddl_charReplace.SelectedItem as ListMember;
        var dir_target = Path.Combine(input_gamefolder.Text, "chr", chooseChar.value, chooseTarget.value, $"{chooseTarget.value}.pac");
        var dir_replace = Path.Combine(input_gamefolder.Text, "chr", chooseChar.value, chooseReplace.value, $"{chooseReplace.value}.pac");
        if (chooseReplace.label.Contains("basebody"))
        {
            dir_replace = Path.Combine(input_gamefolder.Text, "chr", chooseChar.value, chooseReplace.value);
        }
        BakFile(dir_target);
        File.Copy(dir_replace, dir_target, true);
        MessageBox.Show($"the char \"{chooseChar.value}\" replace \"{chooseTarget.value}\" from \"{chooseReplace.value}\" success!");
    }
    private void btn_restore_Click(object sender, EventArgs e)
    {
        var chooseChar = ddl_char.SelectedItem as ListMember;
        var chooseTarget = ddl_charTarget.SelectedItem as ListMember;
        var dir_target = Path.Combine(input_gamefolder.Text, "chr", chooseChar.value, chooseTarget.value, $"{chooseTarget.value}.pac");
        if (RestoreFile(dir_target))
        {
            MessageBox.Show("restore success");
        }
        else
        {
            MessageBox.Show("no back file");
        }
    }


    #endregion

    #region tab-group

    private void btn_replace_group_Click(object sender, EventArgs e)
    {
        var choosegroup = ddl_group.SelectedItem as string;
        var chars = charGroups[choosegroup];
        var chooseTarget = ddl_target_group.SelectedItem as ListMember;
        var chooseReplace = ddl_replace_group.SelectedItem as ListMember;
        var results = new Dictionary<string, string>();
        foreach (var chr in chars)
        {
            var dir_target = Path.Combine(input_gamefolder.Text, "chr", chr, chooseTarget.value, $"{chooseTarget.value}.pac");
            var dir_replace = Path.Combine(input_gamefolder.Text, "chr", chr, chooseReplace.value, $"{chooseReplace.value}.pac");
            if (chooseReplace.value == "basebody")
            {
                dir_replace = Path.Combine(input_gamefolder.Text, "chr", chr, $"{chr}.pac");
            }
            if (!File.Exists(dir_target))
            {
                results.Add(chr, $"no such target \"{dir_target}\"");
                continue;
            }
            if (!File.Exists(dir_replace))
            {
                results.Add(chr, $"no such replace \"{dir_replace}\"");
                continue;
            }
            BakFile(dir_target);
            File.Copy(dir_replace, dir_target, true);
            results.Add(chr, "success");
        }
        var msg = string.Join('\n', results.Select(d => $"{d.Key}¡ú{d.Value}"));
        msg = $"replace group char {chooseTarget.value} from {chooseReplace.value} results:\r\n{msg}";
        MessageBox.Show(msg);
    }
    private void btn_restore_group_Click(object sender, EventArgs e)
    {
        var choosegroup = ddl_group.SelectedItem as string;
        var chars = charGroups[choosegroup];
        var chooseTarget = ddl_target_group.SelectedItem as ListMember;
        var results = new Dictionary<string, string>();
        foreach (var chr in chars)
        {
            var dir_target = Path.Combine(input_gamefolder.Text, "chr", chr, chooseTarget.value, $"{chooseTarget.value}.pac");
            if (!File.Exists(dir_target))
            {
                results.Add(chr, $"no such target \"{dir_target}\"");
                continue;
            }
            RestoreFile(dir_target);
            results.Add(chr, "success");
        }
        var msg = string.Join('\n', results.Select(d => $"{d.Key}¡ú{d.Value}"));
        msg = $"restore group char {chooseTarget.value} results:\r\n{msg}";
        MessageBox.Show(msg);
    }
    private void ddl_group_SelectedIndexChanged(object sender, EventArgs e)
    {
        var choosegroup = ddl_group.SelectedItem as string;
        var dir_char = Path.Combine(input_gamefolder.Text, "chr", charGroups[choosegroup][0]);
        var dirs = Directory.GetDirectories(dir_char);
        var listdata = new List<ListMember>();
        foreach (var dir in dirs)
        {
            var dir_name = dir.Substring(dir.LastIndexOf('\\') + 1);
            listdata.Add(new ListMember { label = dir_name, value = dir_name });
        }
        ddl_target_group.DataSource = listdata;
        ddl_target_group.SelectedIndex = 0;
        var listdata_new = listdata.ToList();
        listdata_new.Add(new ListMember { label = "basebody", value = "basebody" });
        ddl_replace_group.DataSource = listdata_new;
        ddl_replace_group.SelectedIndex = 0;
        switch (choosegroup)
        {
            case "¦Ì's":
                var find = listdata.FirstOrDefault(d => d.label == "d001");
                if (find != null)
                {
                    ddl_target_group.SelectedItem = find;
                }
                break;
            case "Aqours":
                var find2 = listdata.FirstOrDefault(d => d.label == "d090");
                if (find2 != null)
                {
                    ddl_target_group.SelectedItem = find2;
                }
                break;
            default:
                var find3 = listdata.FirstOrDefault(d => d.label == "d200");
                if (find3 != null)
                {
                    ddl_target_group.SelectedItem = find3;
                }
                break;
        }
    }

    #endregion


}
class ListMember
{
    public string label { get; set; }
    public string value { get; set; }
}